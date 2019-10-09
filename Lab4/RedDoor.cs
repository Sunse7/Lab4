using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class RedDoor : Tile, IInteractable
    {
        public bool isOpen { get; private set; } = false;
        public RedDoor(int xPos, int yPos) : base(xPos, yPos) { }

        public override void PrintCharToMap()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("D");
            Console.ResetColor();
        }

        public override bool CanPass()
        {
            return isOpen;
        }

        public void PlayerInteract(GameStateManager gameState)
        {
            if (isOpen == false && gameState.player.HasRedKey)
            {
                isOpen = true;
                gameState.player.HasRedKey = false;
                Console.WriteLine("As you unlock the door, the key is destroyed. You enter the next room.");
            }
            else if (gameState.player.HasRedKey == false && isOpen == false)
            {
                Console.WriteLine("You do not have the key to open this door");
            }
            Console.ReadKey(true);
        }
    }
}
