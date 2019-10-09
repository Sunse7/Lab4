using System;

namespace Lab4
{
    class GreenKey : Tile, IInteractable
    {
        public GreenKey(int xPos, int yPos) : base(xPos, yPos) { }

        public override void PrintCharToMap()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("K");
            Console.ResetColor();
        }

        public void PlayerInteract(GameStateManager gameState)
        {
            gameState.player.HasGreenKey = true;
            gameState.roomObjectList.Remove(this);
            gameState.roomObjectList.Add(new FloorTile(Xposition, Yposition));
            Console.WriteLine("You pick up a shiny green key.");
            Console.ReadKey(true);
        }
    }
}