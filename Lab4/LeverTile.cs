using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class LeverTile : Tile, IInteractable
    {
        public LeverTile(int xPos, int yPos) : base(xPos, yPos) { }

        public override void PrintCharToMap()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("L");
            Console.ResetColor();
        }
        // Remove hardcoding if you wish to create a new map format.

        public void PlayerInteract(GameStateManager gameState)
        {
            gameState.roomObjectList.Remove(this);
            gameState.roomObjectList.Remove(gameState.GetTileObject(17, 1));
            gameState.roomObjectList.Remove(gameState.GetTileObject(17, 7));
            gameState.roomObjectList.Add(new FloorTile(Xposition, Yposition));
            gameState.roomObjectList.Add(new FloorTile(17, 1));
            gameState.roomObjectList.Add(new FloorTile(17, 7));
            Console.WriteLine("You search the wall and find a poorly 'hidden' lever. You pull it and the wall opens into a secret passage.");
            Console.ReadKey(true);
        }
    }
}
