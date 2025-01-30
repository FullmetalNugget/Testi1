namespace TaulukkoMonistus;
using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[5];
        int[] copyNumbers = new int[5];

        Console.WriteLine("Syötä 5 numeroa");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Numero {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            copyNumbers[i] = numbers[i];
        }

        Console.WriteLine("\nEka taulukko:");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine("\nToka taulukko:");
        foreach (int num in copyNumbers)
        {
            Console.Write(num + " ");
        }
    }
}