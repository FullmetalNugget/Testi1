namespace Valtakuntien_Herruus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Montako Maatilaa?");
            int maatila = int.Parse(Console.ReadLine());
            Console.WriteLine("Montako herttuakuntaa ?");
            int herttuakuntaa = int.Parse(Console.ReadLine());
            Console.WriteLine("Montako maakuntaa?");
            int maakuntaa = int.Parse(Console.ReadLine());
            Console.WriteLine($"Pisteet: {maatila + herttuakuntaa * 3 + maakuntaa * 6}");
        }
    }
}
