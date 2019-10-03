
using System;

namespace Lab4
{
    class BlueKey : Tiles, IInteractable
    {

        public BlueKey(int xPos, int yPos)
        {
            Xposition = xPos;
            Yposition = yPos;
        }

        public override void PrintCharToMap()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("K");
            Console.ResetColor();
        }

        public void PlayerInteract()
        {
            PlayerTile.HasBlueKey = true;
            PrintMapAndMove.roomObjectList.Remove(this);
            PrintMapAndMove.roomObjectList.Add(new FloorTile(Xposition, Yposition));
            // TODO: Print description
        }

        public void PrintTileInfo()
        {
            //TODO: Print description
        }
    }
}