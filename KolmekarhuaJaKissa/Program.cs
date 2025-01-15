namespace KolmekarhuaJaKissa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kuinkas monta kalaa on karhut napannut???");
            int kala = int.Parse(Console.ReadLine());
            Console.WriteLine($"Karhuille menee {kala / 4} ja kissalle menee {kala % 4}");
        }
    }
}
