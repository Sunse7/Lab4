using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class PrintMapAndMove //detta är ett verb, ett objekt är ett subjektiv. Så, vad är det den hära samlingen av logik och data är? Kanske bör heta Game
        //och försök att dela upp data och logik i olika klasser. Sen så är det definitivt inget problem att gruppera ihop på detta viset och skapa en
        //övergripande klass som har flera funktioner. Men det är mindre modulärt. Alltså är skateboarden något ihopsvetsad. Som blir ett problem i framtiden.
        //Men om vi vet att vi aldrig kommer ändra på den, så är det mer rätt att göra så här. Och det kan man definitivt argumentera för, eftersom det är
        //en finito inlämning.
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

        public int MovementControl() //hela gameloopen, eftersom du har alla kontrollregler, grafik och så vidare.
        {
            GenerateMapObjects();

            while(true)
            {
                //Prints the whole game state ??
                {
                    PrintMap();
                    player.PrintInventory(); 
                }
                Tiles currentRoom = GetTileObject(player.Xposition, player.Yposition);
                TotalMovesMade += currentRoom.MovementCost;

                if (currentRoom != null && currentRoom.HasWon() == true)
                {
                    return TotalMovesMade;
                }
                
                //Input och kontrollflöde av spelregler, Tycker absoult du flyttar input och kontroll flöde till egna klasser, t ex inputmanager. och gamerules jag vet inte. kanske game. 
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.W:
                        if (RequestMove(player.Xposition, player.Yposition - 1) == true)
                            player.Yposition--;
                        break;
                    case ConsoleKey.S:
                        if (RequestMove(player.Xposition, player.Yposition + 1) == true)
                            player.Yposition++;
                        break;
                    case ConsoleKey.D:
                        if (RequestMove(player.Xposition + 1, player.Yposition) == true)
                            player.Xposition++;
                        break;
                    case ConsoleKey.A:
                        if (RequestMove(player.Xposition - 1, player.Yposition) == true)
                            player.Xposition--;
                        break;
                }
            }
        }

        public bool RequestMove(int x, int y)
        {
            Tiles direction = GetTileObject(x, y);
            if (direction is IInteractable)
                (direction as IInteractable).PlayerInteract();

            return direction.CanPass();
        }

        public void PrintMap() //print gamestate? Skriver ut hela tillståndet av spelet, inte bara kartan
        {
            // Prints the map symbols for all objects of Walltile and Tiles that surround the current player position.
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
