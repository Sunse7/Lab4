using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class FloorTile : Tiles
    {
        public override string MapSymbol { get; } = "-";

        public FloorTile(int posX, int posY)
        {
            Xposition = posX;
            Yposition = posY;
        }

        public override void PrintTileInfo(string description, string contains)
        {
            base.PrintTileInfo("an empty room.", "There is nothing here");
        }
    }
}
