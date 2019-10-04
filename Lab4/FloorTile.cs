using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class FloorTile : Tiles
    {
        public FloorTile(int xPos, int yPos) : base(xPos, yPos) { }
        public override void PrintCharToMap()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("-");
            Console.ResetColor();
        }
    }
}
