using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class WallTile : Tiles
    {
        public WallTile(int xPos, int yPos) : base(xPos, yPos) { }
        public override void PrintCharToMap()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("#");
            Console.ResetColor();
        }
        public override bool CanPass()
        {
            Console.WriteLine("As cool as you are, you are not cool enough to phase through walls...");
            Console.ReadKey(true);
            return false;
        }
    }
}
