using System;

namespace Arvauspeli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pelaaja 1 anna numero 1-100:");
            int salainenNumero = int.Parse(Console.ReadLine());

            // Tyhjennetään konsoli
            Console.Clear();

            Console.WriteLine("Pelaaja 2 arvaa Pelaaja 1 numero 1-100!");

            int arvaus;
            while (true)
            {
                Console.Write("Mitä veikkaat? ");
                arvaus = int.Parse(Console.ReadLine());

                if (arvaus < salainenNumero)
                {
                    Console.WriteLine($"{arvaus} on liian pieni!");
                }
                else if (arvaus > salainenNumero)
                {
                    Console.WriteLine($"{arvaus} on liian suuri!");
                }
                else
                {
                    Console.WriteLine("Aivan oikein!");
                    break;
                }
            }
        }
    }
}