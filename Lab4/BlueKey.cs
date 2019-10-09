
using System;

namespace Lab4
{
    class BlueKey : Tile, IInteractable
    {
        public BlueKey(int xPos, int yPos):base(xPos,yPos){ }

        public override void PrintCharToMap()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("K");
            Console.ResetColor();
        }

        public void PlayerInteract(GameStateManager gameState)
        {
            gameState.player.HasBlueKey = true;
            gameState.roomObjectList.Remove(this);
            gameState.roomObjectList.Add(new FloorTile(Xposition, Yposition));
            Console.WriteLine("You pick up a shiny blue key.");
            Console.ReadKey(true);
        }
    }
}