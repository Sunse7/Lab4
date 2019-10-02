using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    abstract class DoorTile : Tiles
    {

        

        public virtual new string MapSymbol { get; } = "";
        public virtual string Colour { get; } = "";
        protected bool isOpen = false;
        protected bool hasKey = false;

        public bool DoorCheck()
        {
            
        }
    }
}
