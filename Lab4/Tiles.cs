using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    abstract class Tiles
    {

        // TODO; Add X/Y positions of Neighbouring tiles. Print if PlayerPos == This.Pos

        public int Xposition { get; protected set; }

        public int Yposition { get; protected set; }

        public virtual int MovementCost { get; } = 1;

        public virtual bool CanPass()
        {
            return true;
        }

        public virtual void PrintCharToMap()
        {
            Console.Write("");
        }

        public virtual void PrintTileInfo(string description, string contains)
        {
            Console.WriteLine($"You enter {description} \n {contains}");
        }

    }
}
