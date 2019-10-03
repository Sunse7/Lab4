using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{

    class PrintMapAndMove
    {
        List<object> roomObjectList = new List<object> {};

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
