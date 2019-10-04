
using System;

namespace Lab4
{
    class BlueKey : Tiles, IInteractable
    {
        public BlueKey(int xPos, int yPos):base(xPos,yPos){ }
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
            Console.WriteLine("You pick up a shiny blue key.");
            Console.ReadKey(true);
        }
    }
}