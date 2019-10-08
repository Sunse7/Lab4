using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class LeverTile : Tiles, IInteractable
    {
        public LeverTile(int xPos, int yPos) : base(xPos, yPos) { }
        public override void PrintCharToMap()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("L");
            Console.ResetColor();
        }

        //TODO: Remove hardcoding when we make another level
        public void PlayerInteract()
        {
            PrintMapAndMove.roomObjectList.Remove(this);
            PrintMapAndMove.roomObjectList.Remove(PrintMapAndMove.GetTileObject(17, 1));
            PrintMapAndMove.roomObjectList.Remove(PrintMapAndMove.GetTileObject(17, 7));
            PrintMapAndMove.roomObjectList.Add(new FloorTile(Xposition, Yposition));
            PrintMapAndMove.roomObjectList.Add(new FloorTile(17, 1));
            PrintMapAndMove.roomObjectList.Add(new FloorTile(17, 7));
            Console.WriteLine("You search the wall and find a poorly 'hidden' lever. You pull it and the wall opens into a secret passage.");
            Console.ReadKey(true);
        }
    }
}
