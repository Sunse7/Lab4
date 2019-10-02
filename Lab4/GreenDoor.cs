using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class GreenDoor : Tiles
    {
        public override string MapSymbol { get; } = string.Format("D", Console.ForegroundColor = ConsoleColor.Green);
        protected bool isOpen = false;
        protected bool hasKey = false;

        public bool CanPass()
        {
            if (isOpen == true)
                return true;
            if (isOpen == false && hasKey == false)
            {
                Console.WriteLine("You don't have the right key to open this door...");
                Console.ReadKey(true);
                return false;
            }
            else if (isOpen == false && hasKey == true)
            {
                isOpen = true;
                hasKey = false;
            }
        }
        public override void PrintTileInfo(string description, string contains)
        {
            base.PrintTileInfo(description, contains);
        }
    }
}
