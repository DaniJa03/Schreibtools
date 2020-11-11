using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung
{
    class Stift
    {
        abstract class Stift1
        {
            public int Strichstarke { get; set; }
            public ConsoleColor Farbe { get; set; }
            public Type Text { get; set; }
        }
    }
}
