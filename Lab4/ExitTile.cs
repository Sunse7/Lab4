using System;

namespace Lab4
{
    class ExitTile : Tile
    {
        public ExitTile(int xPos, int yPos) : base(xPos, yPos) { }

        public override void PrintCharToMap()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("E");
            Console.ResetColor();
        }

        public override bool HasWon()
        {
            return true;
        }
    }
}