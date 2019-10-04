using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class BlueDoor : Tiles, IInteractable
    {
        public bool isOpen { get; private set; } = false;

        public BlueDoor(int xPos, int yPos) : base(xPos, yPos) { }

        public override void PrintCharToMap()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("D");
            Console.ResetColor();
        }

        public override bool CanPass()
        {
            return isOpen;
        }

        public void PlayerInteract()
        {
            if (isOpen == false && PlayerTile.HasBlueKey)
            {
                isOpen = true;
                PlayerTile.HasBlueKey = false;
                Console.WriteLine("As you unlock the door, the key is destroyed. You enter the next room.");
            }
            else if (PlayerTile.HasBlueKey == false && isOpen == false)
            {
                Console.WriteLine("You do not have the key to open this door");
            }
            Console.ReadKey(true);
        }
    }
}
