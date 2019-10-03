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

        string[,] mapArray = new string[,]
        { 
          { "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#" },
          { "#", "BK", "-", "S", "-", "RD", "-", "RK", "@", "-", "-", "-", "-", "-", "-", "-", "L", "#", "-", "#" },
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
                Tiles room = CurrentPlayerRoom();

                if (room.HasWon())
                {
                    break;
                }

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.W:
                        if (room != null && room.CanPass())
                        {
                            PlayerTile.Yposition++;
                        }
                        break;
                    case ConsoleKey.S:
                        if (room != null && room.CanPass())
                        {
                            PlayerTile.Yposition--;
                        }
                        break;
                    case ConsoleKey.D:
                        if (room != null && room.CanPass())
                        {
                            PlayerTile.Xposition++;
                        }
                        break;
                    case ConsoleKey.A:
                        if (room != null && room.CanPass())
                        {
                            PlayerTile.Yposition--;
                        }
                        break;
                    default:
                        break;
                }
            }
            return TotalMovesMade;
        }

        public void PrintMap()
        {
            Tiles room = CurrentPlayerRoom();
            if (room != null)
            {
                for (int i = 0; i < mapArray.GetLength(0); i++)
                {
                    for (int j = 0; j < mapArray.GetLength(0); j++)
                    {
                        if (i == room.Xposition && j == room.Yposition)
                        {
                            // Find a good way to print tiles surrounding the player position
                        }
                    }
                }
            }
        }

        public Tiles CurrentPlayerRoom()
        {
            foreach (Tiles tile in roomObjectList)
            {
                if (tile.Xposition == PlayerTile.Xposition && tile.Yposition == PlayerTile.Yposition)
                {
                    return tile;
                }
            }
            return null;
        }

        public void GenerateMapObjects()
        {
            for (int i = 0; i < mapArray.GetLength(0); i++)
            {
                for (int j = 0; j < mapArray.GetLength(1); j++)
                {
                    if (mapArray[i, j] == "E")
                    {
                        roomObjectList.Add(new ExitTile(i,j));
                    }
                    else if (mapArray[i, j] == "L")
                    {
                        roomObjectList.Add(new LeverTile(i, j));
                    }
                    else if (mapArray[i, j] == "@")
                    {
                        roomObjectList.Add(new PlayerTile(i, j));
                        roomObjectList.Add(new FloorTile(i, j));
                    }
                    else if (mapArray[i, j] == "RK")
                    {
                        roomObjectList.Add(new RedKey(i, j));
                    }
                    else if (mapArray[i, j] == "BK")
                    {
                        roomObjectList.Add(new BlueKey(i, j));
                    }
                    else if (mapArray[i, j] == "GK")
                    {
                        roomObjectList.Add(new GreenKey(i, j));
                    }
                    else if (mapArray[i, j] == "RD")
                    {
                        roomObjectList.Add(new RedDoor(i, j));
                    }
                    else if (mapArray[i, j] == "BD")
                    {
                        roomObjectList.Add(new BlueDoor(i, j));
                    }
                    else if (mapArray[i, j] == "GD")
                    {
                        roomObjectList.Add(new GreenDoor(i, j));
                    }
                    else if (mapArray[i, j] == "M")
                    {
                        roomObjectList.Add(new MonsterTile(i, j));
                    }
                    else if (mapArray[i, j] == "S")
                    {
                        roomObjectList.Add(new Sword(i, j));
                    }
                    else if (mapArray[i, j] == "#")
                    {
                        roomObjectList.Add(new WallTile(i, j));
                    }
                    else if (mapArray[i, j] == "-")
                    {
                        roomObjectList.Add(new FloorTile(i, j));
                    }
                }
            }
        }

            //Console.WriteLine("\n\n[@ = Player] [D = Door] [I = Item] [N = Key]\n" +
                              //"[M = Monster] [L = Lever] [- = Empty tile] [# = Wall]\n[E = Exit]");
    }
}
