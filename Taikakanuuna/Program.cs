using System;

class PuolustusTorni
{
    static void TulostaAmmus(int number)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write($"{number}: ");

        if (number % 3 == 0 && number % 5 == 0)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Electric & Fire");
        }
        else if (number % 3 == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Fire");
        }
        else if (number % 5 == 0)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Electric");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Normal");
        }

        Console.ResetColor();
    }

    static void Main(string[] args)
    {
        for (int number = 1; number <= 100; number++)
        {
            TulostaAmmus(number);
        }
    }
}