using System;

namespace Lab4
{
    class Sword : Tile, IInteractable
    {
        public Sword(int xPos, int yPos):base(xPos,yPos){ }

        public override void PrintCharToMap()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("S");
            Console.ResetColor();
        }

        public void PlayerInteract(GameStateManager gameState)
        {
            gameState.player.HasSword = true;
            gameState.roomObjectList.Remove(this);
            gameState.roomObjectList.Add(new FloorTile(Xposition, Yposition));
            Console.WriteLine("You pick up a sharp looking sword.");
            Console.ReadKey(true);
        }
    }
}