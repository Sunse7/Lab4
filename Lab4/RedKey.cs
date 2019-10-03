using System;

namespace Lab4
{
    class RedKey : Tiles, IInteractable
    {

        public RedKey(int xPos, int yPos)
        {
            Xposition = xPos;
            Yposition = yPos;
        }

        public override void PrintCharToMap()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("K");
            Console.ResetColor();
        }

        public void PlayerInteract()
        {
            PlayerTile.HasRedKey = true;
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