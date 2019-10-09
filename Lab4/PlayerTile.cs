using System;

namespace Lab4
{
    class PlayerTile : Tile
    {
        public bool HasBlueKey { get; set; } = false;
        public bool HasRedKey { get; set; } = false;
        public bool HasGreenKey { get; set; } = false;
        public bool HasSword { get; set; } = false;
        public PlayerTile(int xPos, int yPos) : base(xPos, yPos) { }

        public override void PrintCharToMap()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("@");
            Console.ResetColor();
        }

        public void PrintInventory()
        {
            Console.WriteLine( "{0} {1} {2} {3}\n", 
                HasBlueKey ? "[Blue Key]" : "",
                HasRedKey ? "[Red Key]" : "",
                HasGreenKey ? "[Green Key]" : "",
                HasSword ? "[Sword]" : "" );
        }
    }
}
