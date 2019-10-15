using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class GameStateManager 
    {
        public PlayerTile player = new PlayerTile(8, 1);
        public List<Tile> roomObjectList = new List<Tile> {};
        string[,] mapArray = new string[,]
        { 
          { "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#" },
          { "#", "BK", "-", "S", "-", "RD", "-", "RK", "-", "-", "-", "-", "-", "-", "-", "-", "L", "#", "-", "#" },
          { "#", "#", "#", "#", "#", "#", "#", "#", "M", "#", "#", "#", "#", "#", "#", "#", "#", "#", "-", "#" },
          { "#", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "BD", "-", "S", "-", "GK", "#", "-", "#" },
          { "#", "#", "#", "#", "#", "#", "#", "#", "M", "#", "#", "#", "#", "#", "#", "#", "#", "#", "-", "#" },
          { "#", "-", "-", "S", "-", "GD", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "#", "-", "#" },
          { "#", "#", "#", "#", "#", "#", "#", "#", "M", "#", "#", "#", "#", "#", "#", "#", "#", "#", "-", "#" },
          { "#", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "#", "-", "#" },
          { "#", "#", "#", "#", "#", "#", "#", "#", "E", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#" }
        };

        public void PrintGamestate()
        {
            // Prints the map symbols for all objects of Walltile, Tiles that surround the current player position, map legend, and player inventory.
            Console.Clear();
            for (int y = 0; y < mapArray.GetLength(0); y++)
            {
                for (int x = 0; x < mapArray.GetLength(1); x++)
                {
                    if (x >= player.Xposition - 1 && x <= player.Xposition + 1
                        && y <= player.Yposition + 1 && y >= player.Yposition -1)
                    {
                        if (x == player.Xposition && y == player.Yposition)
                        {
                            player.PrintCharToMap();
                            continue;
                        }
                        GetTileObject(x,y).PrintCharToMap();
                        continue;
                    }
                    else if (GetTileObject(x,y) is WallTile)
                    {
                        GetTileObject(x,y).PrintCharToMap();
                        continue;
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine("");
            }

            Console.WriteLine("\n\n[@ = Player] [D = Door] [S = Sword] [K = Key]\n" +
                "[M = Monster] [L = Lever] [- = Empty tile] [# = Wall]\n[E = Exit]\n");
            player.PrintInventory();
        }

        public Tile GetTileObject(int x, int y)
        {
            foreach (Tile tile in roomObjectList)
            {
                if (tile.Xposition == x && tile.Yposition == y)
                {
                    return tile;
                }
            }
            return null;
        }

        public void GenerateMapObjects()
        {
            for (int y = 0; y < mapArray.GetLength(0); y++)
            {
                for (int x = 0; x < mapArray.GetLength(1); x++)
                {
                    int temp = mapArray.GetLength(1);
                    if (mapArray[y, x] == "E")
                    {
                        roomObjectList.Add(new ExitTile(x,y));
                        continue;
                    }
                    else if (mapArray[y, x] == "L")
                    {
                        roomObjectList.Add(new LeverTile(x, y));
                        continue;
                    }
                    else if (mapArray[y, x] == "RK")
                    {
                        roomObjectList.Add(new RedKey(x, y));
                        continue;
                    }
                    else if (mapArray[y, x] == "BK")
                    {
                        roomObjectList.Add(new BlueKey(x, y));
                        continue;
                    }
                    else if (mapArray[y, x] == "GK")
                    {
                        roomObjectList.Add(new GreenKey(x, y));
                        continue;
                    }
                    else if (mapArray[y, x] == "RD")
                    {
                        roomObjectList.Add(new RedDoor(x, y));
                        continue;
                    }
                    else if (mapArray[y, x] == "BD")
                    {
                        roomObjectList.Add(new BlueDoor(x, y));
                        continue;
                    }
                    else if (mapArray[y, x] == "GD")
                    {
                        roomObjectList.Add(new GreenDoor(x, y));
                        continue;
                    }
                    else if (mapArray[y, x] == "M")
                    {
                        roomObjectList.Add(new MonsterTile(x, y));
                        continue;
                    }
                    else if (mapArray[y, x] == "S")
                    {
                        roomObjectList.Add(new Sword(x, y));
                        continue;
                    }
                    else if (mapArray[y, x] == "#")
                    {
                        roomObjectList.Add(new WallTile(x, y));
                        continue;
                    }
                    else if (mapArray[y, x] == "-")
                    {
                        roomObjectList.Add(new FloorTile(x, y));
                        continue;
                    }
                }
            }
        }
    }
}
