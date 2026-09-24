using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_HalloNaam
{
    internal class Program
    {
        static void Main(string[] args)
        {   /*
            * Yorid schepens
            * 22/09/2026
            * Hallo naam
            */

            //Velden
            String _naamGebruiker = null;
            String _bewerking = null;
            //Programma
            //Stap 1: Vraag naam + opslaan
            Console.Write("Geef je naam: ");
            _naamGebruiker = Console.ReadLine();

            //Stap 2: maak de juiste tekst
            //_bewerking = "Hallo " + _naamGebruiker;
            _bewerking = $"Hallo {_naamGebruiker}";

            
            //Scherm wissen
            Console.Clear();

            //Stap 3: toon de tekst in de juiste vorm
            Console.WriteLine(_bewerking);


        }
    }
}
