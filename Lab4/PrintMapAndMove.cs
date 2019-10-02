using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{

    class PrintMapAndMove
    {
        List<object> roomObjectList = new List<object> {};

        string[,] mapArray = new string[,]
        { 
          { "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#" },
          { "#", "N", "-", "I", "-", "D", "-", "-", "@", "-", "-", "-", "-", "-", "-", "-", "L", "#", "-", "#" },
          { "#", "#", "#", "#", "#", "#", "#", "#", "M", "#", "#", "#", "#", "#", "#", "#", "#", "#", "-", "#" },
          { "#", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "D", "-", "I", "-", "N", "#", "-", "#" },
          { "#", "#", "#", "#", "#", "#", "#", "#", "M", "#", "#", "#", "#", "#", "#", "#", "#", "#", "-", "#" },
          { "#", "N", "-", "I", "-", "D", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "#", "-", "#" },
          { "#", "#", "#", "#", "#", "#", "#", "#", "M", "#", "#", "#", "#", "#", "#", "#", "#", "#", "-", "#" },
          { "#", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "#", "-", "#" },
          { "#", "#", "#", "#", "#", "#", "#", "#", "E", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#", "#" }
        };

            

        public void TestPrint()
        {
            for (int i = 0; i < mapArray.GetLength(0); i++)
            {
                for (int j = 0; j < mapArray.GetLength(1); j++)
                {
                    Console.Write(mapArray[i, j]);
                }
                Console.WriteLine("");
            }

            Console.WriteLine("\n\n[@ = Player] [D = Door] [I = Item] [N = Key]\n" +
                              "[M = Monster] [L = Lever] [- = Empty tile] [# = Wall]\n[E = Exit]");
        }
        
    }
}
