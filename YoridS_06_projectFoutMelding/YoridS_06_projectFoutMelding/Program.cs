using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoridS_06_projectFoutMelding
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
          * Yorid Schepens
          * Project foutmelding
          * 01/10/2026
          */

            //velden
            int _getal = 0;
            //programma
            try
            {
                //stap 1: Vraag een getal + opslaan
                Console.Write("Geef een natuurlijk getal: ");
                _getal = int.Parse(Console.ReadLine());

                Console.Clear();
                //stap 2: Toon de tekst
                Console.WriteLine("Getal ontvangen!");
            }
            catch
            {
                Console.Clear();
                //of de foutmelding 
                Console.WriteLine("Er ging iets fout.");
            }




        }
    }
}
