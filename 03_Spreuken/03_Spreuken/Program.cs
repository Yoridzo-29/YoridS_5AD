using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Spreuken
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Yorid Schepens
             * 18/09/2026
             * Spreuken
             */
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.Green;
            //toon de spreuken op el beeld
            //toon zin 1
            Console.WriteLine("Met hard werken en streng zijn voor jezelf, kom je heel ver in het leven");
            Console.WriteLine();
            //vraag om een toets in te drukken
            Console.WriteLine("Druk op een toets om verder te gaan");
            Console.ReadKey();

            //scherm wissen
            Console.Clear();

            //toon zin 2
            Console.WriteLine("Een diploma zorgt ervoor dat je een hoger loon start");
            Console.WriteLine();
            
            //vraag om een toets in te drukken
            Console.WriteLine("Druk op een toets om verder te gaan");
            Console.ReadKey();

            //scherm wissen
            Console.Clear();

            //nieuwe kleur
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Cyan;

            //toon zin 3
            Console.WriteLine("Programmeren is eerst analyseren in kleine stapjes");
            Console.WriteLine();
            Console.WriteLine("Druk op een toets om verder te gaan");
            Console.ReadKey();

            //scherm wissen
            Console.Clear();
        }
    }
}
