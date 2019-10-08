using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class GreenDoor : Tile, IInteractable
    {
        public bool isOpen { get; private set; } = false;
        public GreenDoor(int xPos, int yPos) : base(xPos, yPos) { }

        public override void PrintCharToMap()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("D");
            Console.ResetColor();
        }

        public override bool CanPass()
        {
            return isOpen;
        }

        public void PlayerInteract(GameStateManager gameState)
        {
            if (isOpen == false && gameState.player.HasGreenKey)
            {
                isOpen = true;
                gameState.player.HasGreenKey = false;
                Console.WriteLine("As you unlock the door, the key is destroyed. You enter the next room.");
            }
            else if (gameState.player.HasGreenKey == false && isOpen == false)
            {
                Console.WriteLine("You do not have the key to open this door");
            }
            Console.ReadKey(true);
        }
    }
}
