using System;

namespace Lab4
{
    class GreenKey : Tiles, IInteractable
    {

        public GreenKey(int xPos, int yPos)
        {
            Xposition = xPos;
            Yposition = yPos;
        }

        public override void PrintCharToMap()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("K");
            Console.ResetColor();
        }

        public void PlayerInteract()
        {
            PlayerTile.HasGreenKey = true;
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