using System;

class Program
{
    public static int AskForNumber(string question)
    {
        Console.WriteLine(question);

        while (true)
        {
            string input = Console.ReadLine();

            if (int.TryParse(input, out int result))
            {
                return result;
            }
            else
            {
                Console.WriteLine("Tämä ei ole numero vitun idiootti!");
            }
        }
    }
    static void Main(string[] args)
    {
        int result = AskForNumber("Mikä on koiran maksiminopeus km/h?");
        Console.WriteLine($"Koiran nopeus lienee: {result} Km/h");
    }
}