using System;

namespace Lab4
{
    class GreenKey : Tiles, IInteractable
    {
        public GreenKey(int xPos, int yPos) : base(xPos, yPos) { }
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
            Console.WriteLine("You pick up a shiny green key.");
            Console.ReadKey(true);
        }
    }
}