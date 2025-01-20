namespace Ritariryhmä_Liikkeelle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ritariryhmä Liikkeelle";
            Console.Write("Anna kuninkaan rivi? ");
            int r = int.Parse(Console.ReadLine());
            Console.Write("Anna kuninkaan sarake? ");
            int c = int.Parse(Console.ReadLine());
            Console.Beep();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            if (r > 1) Console.WriteLine($"Ritari 1 Kohteeseen: ({r - 1}, {c})");
            if (r < 8) Console.WriteLine($"Ritari 2 Kohteeseen: ({r + 1}, {c})");
            if (c > 1) Console.WriteLine($"Ritari 3 Kohteeseen: ({r}, {c - 1})");
            if (c < 8) Console.WriteLine($"Ritari 4 Kohteeseen: ({r}, {c + 1})");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}