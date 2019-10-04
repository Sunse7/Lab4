using System;

namespace Lab4
{
    class Sword : Tiles, IInteractable
    {
        public Sword(int xPos, int yPos):base(xPos,yPos){ }
        public override void PrintCharToMap()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("S");
            Console.ResetColor();
        }
        public void PlayerInteract()
        {
            PlayerTile.HasSword = true;
            PrintMapAndMove.roomObjectList.Remove(this);
            PrintMapAndMove.roomObjectList.Add(new FloorTile(Xposition, Yposition));
            Console.WriteLine("You pick up a sharp looking sword.");
            Console.ReadKey(true);
        }
    }
}