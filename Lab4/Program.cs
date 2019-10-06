using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    // Rename any classes and methods that needs better names, such as PrintMapAndMove.

    // Rename IPassable **DONE**
    // Remove DoorTile, Put all member values from DoorTile into Coloured DoorTiles **DONE**
    // Add CanPass method to all tiles that can block you. **DONE**
    // Enable destruction of key once a door is opened. **DONE**
    // Method to print mapsymbols instead of Field variable? **DONE**
    // Add method to print player neighbouring tiles. **DONE** (Using For loops rather than methods in objects.)
    // Figure out how to print map **DONE**
    // Finish all classes **DONE**
    class Program
    {
        static void Main(string[] args)
        {
            PrintMapAndMove runGame = new PrintMapAndMove();
            int playerScore = runGame.MovementControl();
            Console.WriteLine($"Congratulations! You managed to find the exit in {playerScore} moves!\nThank you for playing!" +
                $"\nPress any key to exit the game...");
            Console.ReadKey(true);
        }
    }
}
