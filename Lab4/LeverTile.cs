using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class LeverTile : Tiles, IInteractable
    {

        // Add all neede base member values

        public LeverTile(int xPos, int yPos)
        {
            Xposition = xPos;
            Yposition = yPos;
        }


        public void UseLever()
        {
            if (IsUsed == true)
            {
                //mapArray[1, 17] = "-";
                //mapArray[1, 18] = "-";
                //mapArray[7, 18] = "-";
            }   //
        }
    }
}
