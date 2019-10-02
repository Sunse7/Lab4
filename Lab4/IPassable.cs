using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    interface IPassable
    {
        int Xposition { get; set; }
        int Yposition { get; set; }

        bool CanPass();
    }
}
