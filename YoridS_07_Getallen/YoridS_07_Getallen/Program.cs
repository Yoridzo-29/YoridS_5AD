using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoridS_07_Getallen
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
          * Yorid Schepens
          * Project getallen
          * 1/10/2026
          */

            //velden
            int _eersteGetal = 0;
            int _tweedeGetal = 0;
            int _derdeGetal = 0;
            //programma
            try
            {
                //stap 1: Vraag een eerste getal + opslaan
                Console.WriteLine("Geef een eerste natuurlijk getal: ");
                _eersteGetal = int.Parse(Console.ReadLine());

                //stap 2: Vraag een tweede getal + opslaan
                Console.WriteLine("Geef een eerste natuurlijk getal: ");
                _tweedeGetal = int.Parse(Console.ReadLine());

                //stap 3: Vraag een derde getal + opslaan
                Console.WriteLine("Geef een eerste natuurlijk getal: ");
                _derdeGetal = int.Parse(Console.ReadLine());

                //scherm wissen
                Console.Clear();

                //stap 4: Toon de juiste tekst
                Console.WriteLine($"Dit was het 3de getal: {_derdeGetal.ToString()} \nDit was het 2de getal: {_tweedeGetal.ToString()} \nDit was het 1ste getal {_eersteGetal.ToString()}");
             }
             catch
            {
                //scherm wissen
                Console.Clear();

                //foutmelding
                Console.WriteLine("U gaf geen getal in.");
                Console.WriteLine("\nDruk op enter om af te sluiten.");

        }
    }
}
