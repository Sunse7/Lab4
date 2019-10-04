using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class MonsterTile : Tiles, IInteractable
    {
        public bool isAlive { get; private set; } = true;
        public MonsterTile(int xPos, int yPos) : base(xPos, yPos) { }
        public override int MovementCost
        {
            get
            {
                if (isAlive)
                {
                    Console.WriteLine("You slowly sneak past the sleeping monster.");
                    return 20;
                }
                else
                {
                    return 2;
                }
            }
        }
        public override void PrintCharToMap()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("M");
            Console.ResetColor();
        }
        public void PlayerInteract()
        {
            if(PlayerTile.HasSword)
            {
                isAlive = false;
                PlayerTile.HasSword = false;
                PrintMapAndMove.roomObjectList.Remove(this);
                PrintMapAndMove.roomObjectList.Add(new FloorTile(Xposition, Yposition));
                Console.WriteLine("You bravely slay the monster while it sleeps. Good for you.");
                Console.ReadKey(true);
            }
        }

    }
}
