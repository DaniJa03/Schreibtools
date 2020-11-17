using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung
{  
        abstract class Stift
        {
            public double Strichstarke { get; set; }
            public ConsoleColor Farbe { get; set; }
            public string Type { get; set; }

            public Stift(double Strichstarke)
            {
                this.Strichstarke = Strichstarke;
                Farbe = ConsoleColor.Black;
                Type = "unbekannt";
            }
            
            public Stift(double Strichstarke, ConsoleColor Farbe, string Type)
            {
                this.Farbe = Farbe;
                this.Strichstarke = Strichstarke;
                this.Type = Type;
            }

            public void SchreibeText(string text, ConsoleColor Farbe)
            {
            Console.ForegroundColor = Farbe;
            Console.WriteLine($"(Type: {this.Type}, Farbe: {this.Farbe}, Strichstärke: {this.Strichstarke}, schreibt: {text})");
            }
        }
        
}
