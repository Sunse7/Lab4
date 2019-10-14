using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class InputHandler
    {
        public ConsoleKey PlayerMoveInput()
        {
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.W:
                    return ConsoleKey.W;
                case ConsoleKey.S:
                    return ConsoleKey.S;
                case ConsoleKey.D:
                    return ConsoleKey.D;
                case ConsoleKey.A:
                    return ConsoleKey.A;
                default:
                    return ConsoleKey.Backspace;
            }
        }
    }
}
