using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    // Add method to print player neighbouring tiles.
    // Finish all classes
    // Figure out how to print map
    // Rename any classes that needs a better name, such as PrintMapAndMove.

    // Rename IPassable **DONE**
    // Remove DoorTile, Put all member values from DoorTile into Coloured DoorTiles **DONE**
    // Add CanPass method to all tiles that can block you. **DONE**
    // Enable destruction of key once a door is opened. **DONE**
    // Method to print mapsymbols instead of Field variable? **DONE**

    class Program
    {
        static void Main(string[] args)
        {
            PrintMapAndMove test = new PrintMapAndMove();
            int playerScore = test.MovementControl();
            Console.WriteLine($"Congratulations! You managed to find the exit in {playerScore} moves!\nThank you for playing!" +
                $"\nPress any key to exit the game...");
            Console.ReadKey(true);
        }
    }
}
