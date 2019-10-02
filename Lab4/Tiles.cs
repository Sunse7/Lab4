using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    abstract class Tiles : IPassable
    {

        // TODO; Add X/Y positions of Neighbouring tiles. Print if PlayerPos == This.Pos

        public int Xposition { get;  set; }

        public int Yposition { get;  set; }

        public virtual string MapSymbol { get; } = "";

        public virtual int MovementCost { get; } = 1;

        public virtual bool CanPass()
        {
           
        }

        public virtual void PrintTileInfo(string description, string contains)
        {
            Console.WriteLine($"You enter {description} \n {contains}");
        }

    }
}
