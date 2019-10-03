using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class FloorTile : Tiles
    {

        public FloorTile(int xPos, int yPos)
        {
            Xposition = xPos;
            Yposition = yPos;
        }

        public override void PrintTileInfo(string description, string contains)
        {
            base.PrintTileInfo("an empty room.", "There is nothing here");
        }

        public new bool CanPass()
        {
            return base.CanPass();
        }
    }
}
