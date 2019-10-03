using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class MonsterTile : Tiles
    {
        public override int MovementCost
        {
            get
            {
                if (CanKillMonster())
                {
                    return 2;
                }
                else
                {
                    return 20;
                }
            }
        }

        public MonsterTile(int xPos, int yPos)
        {
            Xposition = xPos;
            Yposition = yPos;
        }

        public bool CanKillMonster()
        {
            if (PlayerTile.HasSword)
            {
                PlayerTile.HasSword = false;
                return true;
            }
            return false;
        }

        public override void PrintTileInfo(string description, string contains)
        {
            base.PrintTileInfo("a monsters lair!", "There is a monster sleeping here.");

        }

    }
}
