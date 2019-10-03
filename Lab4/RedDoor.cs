using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class RedDoor : Tiles, IInteractable
    {

        public bool isOpen { get; private set; } = false;

        public RedDoor(int xPos, int yPos)
        {
            Xposition = xPos;
            Yposition = yPos;
        }

        public override void PrintCharToMap()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("D");
            Console.ResetColor();
        }

        public override bool CanPass()
        {
            if (isOpen == false)
                Console.WriteLine("You do not have the key to open this door.");

            return isOpen;
        }

        public void PlayerInteract()
        {
            if (isOpen == false && PlayerTile.HasRedKey)
            {
                isOpen = true;
                Console.WriteLine("As you unlock the door, the key is destroyed. You enter the next room.");
            }
            else if (PlayerTile.HasRedKey == false && isOpen == false)
            {
                Console.WriteLine("The door won't budge.");
            }
        }

        public void PrintTileInfo()
        {
            //TODO: Print description
        }
    }
}
