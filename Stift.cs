using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung
{  
        abstract class Stift
        {
            public int Strichstarke { get; set; }
            public ConsoleColor Farbe { get; set; }
            public Type Text { get; set; }
        }
}
