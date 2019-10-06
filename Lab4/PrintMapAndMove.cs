using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class PrintMapAndMove
    {
        public int TotalMovesMade { get; private set; } = 0;
        public static List<Tiles> roomObjectList = new List<Tiles> {};
        PlayerTile player = new PlayerTile(8,1);

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

        public int MovementControl()
        {
            GenerateMapObjects();

            while(true)
            {
                PrintMap();

                player.PrintInventory();

                Tiles room = GetTileObject(player.Xposition, player.Yposition);
                TotalMovesMade += room.MovementCost;

                if (room != null && room.HasWon() == true)
                {
                    return TotalMovesMade;
                }
                
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.W:
                        if (GetTileObject(player.Xposition, player.Yposition - 1) is IInteractable)
                            (GetTileObject(player.Xposition, player.Yposition - 1) as IInteractable).PlayerInteract();

                        if (GetTileObject(player.Xposition, player.Yposition - 1).CanPass() == true)
                        {
                            player.Yposition--;
                        }
                        break;
                    case ConsoleKey.S:
                        if (GetTileObject(player.Xposition, player.Yposition + 1) is IInteractable)
                            (GetTileObject(player.Xposition, player.Yposition + 1) as IInteractable).PlayerInteract();

                        if (GetTileObject(player.Xposition, player.Yposition + 1).CanPass() == true)
                        {
                            player.Yposition++;
                        }
                        break;
                    case ConsoleKey.D:
                        if (GetTileObject(player.Xposition + 1, player.Yposition) is IInteractable)
                            (GetTileObject(player.Xposition + 1, player.Yposition) as IInteractable).PlayerInteract();

                        if (GetTileObject(player.Xposition + 1, player.Yposition).CanPass() == true)
                        {
                            player.Xposition++;
                        }
                        break;
                    case ConsoleKey.A:
                        if (GetTileObject(player.Xposition - 1, player.Yposition) is IInteractable)
                            (GetTileObject(player.Xposition - 1, player.Yposition) as IInteractable).PlayerInteract();

                        if (GetTileObject(player.Xposition - 1, player.Yposition).CanPass() == true)
                        {
                            player.Xposition--;
                        }
                        break;
                }
            }
        }
        public void PrintMap()
        {
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
                    }
                    else if (GetTileObject(x,y) is WallTile)
                    {
                        GetTileObject(x,y).PrintCharToMap();
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("");
            }
            Console.WriteLine("\n\n[@ = Player] [D = Door] [S = Sword] [K = Key]\n" +
                "[M = Monster] [L = Lever] [- = Empty tile] [# = Wall]\n[E = Exit]");
        }

        static public Tiles GetTileObject(int x, int y)
        {
            foreach (Tiles tile in roomObjectList)
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
