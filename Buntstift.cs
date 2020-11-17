using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung
{
    class Buntstift : Stift
    {
        public Buntstift(ConsoleColor Farbe, double Strichstärke) : base(Strichstärke, Farbe, "Buntstift")
        {

        }
    }
}
