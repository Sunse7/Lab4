using System;

namespace Lab4
{
    class RedKey : Tile, IInteractable
    {
        public RedKey(int xPos, int yPos) : base(xPos, yPos) { }

        public override void PrintCharToMap()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("K");
            Console.ResetColor();
        }

        public void PlayerInteract(GameStateManager gameState)
        {
            gameState.player.HasRedKey = true;
            gameState.roomObjectList.Remove(this);
            gameState.roomObjectList.Add(new FloorTile(Xposition, Yposition));
            Console.WriteLine("You pick up a shiny red key.");
            Console.ReadKey(true);
        }
    }
}