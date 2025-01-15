namespace Harjoitus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kanta");
            int kanta = int.Parse(Console.ReadLine());
            Console.WriteLine("Korkeus");
            int korkeus = int.Parse(Console.ReadLine());
            Console.WriteLine($"Pinta-ala: {kanta * korkeus / 2}");
        }
    }
}
