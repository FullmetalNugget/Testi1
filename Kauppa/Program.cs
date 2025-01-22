using System;

namespace Kauppa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Kauppa***");
            Console.WriteLine("Inventaario:");
            Console.WriteLine("1 - Miekka");
            Console.WriteLine("2 - Kirves");
            Console.WriteLine("3 - Köysi");
            Console.WriteLine("4 - Kanootti");
            Console.WriteLine("5 - Lusikka & Haarukka");
            Console.WriteLine("6 - Makuupussi");
            Console.WriteLine("7 - Teltta");

            Console.WriteLine("Anna nimesi:");
            string nimi = Console.ReadLine();

            double hintaprosentti = nimi.Equals("Miska", StringComparison.OrdinalIgnoreCase) ? 0.5 : 1.0;

            Console.WriteLine("Minkä esineen hintaa haluaisit tiedustella?");
            string input = Console.ReadLine();

            double alkuperainenHinta = 0;

            switch (input)
            {
                case "1":
                    alkuperainenHinta = 50;
                    break;
                case "2":
                    alkuperainenHinta = 40;
                    break;
                case "3":
                    alkuperainenHinta = 10;
                    break;
                case "4":
                    alkuperainenHinta = 150;
                    break;
                case "5":
                    alkuperainenHinta = 5;
                    break;
                case "6":
                    alkuperainenHinta = 30;
                    break;
                case "7":
                    alkuperainenHinta = 100;
                    break;
            }

            double alennettuHinta = alkuperainenHinta * hintaprosentti;
            Console.WriteLine($"Tuotteen hinta: {alennettuHinta} kultakolikkoa.");
        }
    }
}