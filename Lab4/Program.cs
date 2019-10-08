using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintMapAndMove runGame = new PrintMapAndMove(); //använd inte verb på objekt, som är alltid substantiv
            int playerScore = runGame.MovementControl();
            Console.WriteLine($"Congratulations! You managed to find the exit in {playerScore} moves!\nThank you for playing!" +
                $"\nPress any key to exit the game...");
            Console.ReadKey(true);
        }
    }
}
