using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class BlueDoor : DoorTile
    {
        public override string MapSymbol { get; set; } = string.Format("D", Console.ForegroundColor = ConsoleColor.Blue);
        public override string Colour { get; set; } = "blue";
        public override void PrintTileInfo()
        {
            Console.WriteLine("There is a blue door in this room.");
        }
    }
}
