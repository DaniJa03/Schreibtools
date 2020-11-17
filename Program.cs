    using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Uebung
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<string> Sätze = new List<string>();
            Sätze.Add("Es ist Herbst");
            Sätze.Add("Es ist gerade Herbst");
            Sätze.Add("Der Aktuelle Monat ist Herbst");
            Sätze.Add("Der Sommer ist vorbei und der Winter naht");
            List<Stift> Stifte = new List<Stift>();
            Stifte.Add(new Buntstift(ConsoleColor.Green, 2.0));
            Stifte.Add(new Buntstift(ConsoleColor.Red, 2.0));
            Stifte.Add(new Kugelschreiber(ConsoleColor.DarkGray, 0.7));
            Stifte.Add(new Kugelschreiber(ConsoleColor.Blue, 0.7));
            foreach (var item in Stifte)
            {
                int Satz = rnd.Next(1, 4);
                item.SchreibeText(Sätze[Satz], item.Farbe);
            }
            Console.ReadKey();
        }
    }
}
