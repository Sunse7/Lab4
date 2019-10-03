using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class LeverTile : Tiles, IInteractable
    {

        // Add all needed base member values

        public int GetXPosition { get { return Xposition; } }
        public int GetYPosition { get { return Yposition; } }

        public LeverTile(int xPos, int yPos)
        {
            Xposition = xPos;
            Yposition = yPos;
        }

        public override void PrintCharToMap()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("L");
            Console.ResetColor();
        }

        public void PlayerInteract()
        {
            
            PrintMapAndMove.roomObjectList.Remove(this);
            foreach (var item in PrintMapAndMove.roomObjectList)
            {
                if (item.)
                {

                }
            }
            
            PrintMapAndMove.roomObjectList.Add(new FloorTile(Xposition, Yposition));
            PrintMapAndMove.roomObjectList.Add(new FloorTile(1, 18));
            PrintMapAndMove.roomObjectList.Add(new FloorTile(7, 18));
        }

        public void PrintTileInfo()
        {
            Console.WriteLine("You search the wall and find a poorly 'hidden' lever. You pull it and the wall opens into a secret passage.");
        }
    }
}
