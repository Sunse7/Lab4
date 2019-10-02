using System;

namespace Lab4
{
    class Player : IPassable
    {

        public int Xposition { get; set; }
        public int Yposition { get; set; }
        static public bool HasBlueKey { get; set; } = false;
        static public bool HasRedKey { get; set; } = false;
        static public bool HasGreenKey { get; set; } = false;
        static public bool HasSword { get; set; } = false;

        public Player(int xposition, int yposition)
        {
            Xposition = xposition;
            Yposition = yposition;
        }

        public bool CanPass()
        {

        }

        public void PrintInventory()
        {
            Console.WriteLine( "{0} {1} {2} [{3} Sword(s)]", 
                HasBlueKey ? "[Blue Key]" : "",
                HasRedKey ? "[Red Key]" : "",
                HasGreenKey ? "[Green Key]" : "",
                HasSword ? "[Sword]" : "" );
        }
    }
}
