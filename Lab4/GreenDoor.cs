using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class GreenDoor : Tiles, IInteractable
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
        public void PlayerInteract()
        {
            if (isOpen == false && PlayerTile.HasGreenKey)
            {
                isOpen = true;
                PlayerTile.HasGreenKey = false;
                Console.WriteLine("As you unlock the door, the key is destroyed. You enter the next room.");
            }
            else if (PlayerTile.HasGreenKey == false && isOpen == false)
            {
                Console.WriteLine("You do not have the key to open this door");
            }
            Console.ReadKey(true);
        }
    }
}
