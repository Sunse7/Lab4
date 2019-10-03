using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class WallTile : Tiles
    {

        public WallTile(int xPos, int yPos)
        {
            Xposition = xPos;
            Yposition = yPos;
        }

        public override bool CanPass()
        {
            return false;
        }
    }
}
