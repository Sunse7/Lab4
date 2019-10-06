using System;

namespace Lab4
{
    class RedKey : Tiles, IInteractable
    {
        public RedKey(int xPos, int yPos) : base(xPos, yPos) { }
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
            Console.WriteLine("You pick up a shiny red key.");
            Console.ReadKey(true);
        }
    }
}