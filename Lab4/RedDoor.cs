using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class RedDoor : DoorTile
    {
        public override string MapSymbol { get; set; } = string.Format("D", Console.ForegroundColor = ConsoleColor.Red);
        public override string Colour { get; set; } = "Red";

        public override void PrintTileInfo()
        {
            Console.WriteLine("There is a red door in this room.");
        }
    }
}
