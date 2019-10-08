using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class MonsterTile : Tile, IInteractable
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

        public void PlayerInteract(GameStateManager gameState)
        {
            if(gameState.player.HasSword)
            {
                isAlive = false;
                gameState.player.HasSword = false;
                gameState.roomObjectList.Remove(this);
                gameState.roomObjectList.Add(new FloorTile(Xposition, Yposition));
                Console.WriteLine("You bravely slay the monster while it sleeps. Good for you.");
                Console.ReadKey(true);
            }
        }
    }
}
