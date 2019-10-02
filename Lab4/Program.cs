using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    // Add method to print player neighbouring tiles.
    // Finish all classes
    // Rename IPassable
    // Figure out how to print map
    // Remove DoorTile, Put all member values from DoorTile into Coloured DoorTiles
    // Add CanPass method to all tiles that can block you.
    // Enable destruction of key once a door is opened.
    // Method to print mapsymbols instead of Filed variable?
    class Program
    {
        static void Main(string[] args)
        {
            //pontus was here
            PrintMapAndMove test = new PrintMapAndMove();
            test.TestPrint();
            Console.ReadKey(true);
            
        }
    }
}
