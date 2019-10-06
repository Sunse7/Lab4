using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    abstract class Tiles
    {
        public int Xposition { get; set; }
        public int Yposition { get; set; }
        public virtual int MovementCost { get; } = 1;
        protected Tiles(int xposition, int yposition)
        {
            Xposition = xposition;
            Yposition = yposition;
        }
        public virtual bool CanPass()
        {
            return true;
        }
        public virtual void PrintCharToMap()
        {
            Console.Write("");
        }
        public virtual bool HasWon()
        {
            return false;
        }
    }
}
