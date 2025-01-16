namespace Ritariryhmä_Liikkeelle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ritariryhmä Liikkeelle";
            Console.WriteLine("Anna kuninkaan rivi (1-8):");
            int kingRow = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna kuninkaan sarake (1-8):");
            int kingCol = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Pelikenttä:\n");

            for (int row = 1; row <= 8; row++)
            {
                for (int col = 1; col <= 8; col++)
                {
                    if (row == kingRow && col == kingCol)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("K ");
                    }
                    else if ((row == kingRow - 1 && col == kingCol) ||
                             (row == kingRow + 1 && col == kingCol) ||
                             (row == kingRow && col == kingCol - 1) ||
                             (row == kingRow && col == kingCol + 1))
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("R ");
                        Console.Beep();
                    }
                    else
                    {
                        Console.ResetColor();
                        Console.Write(". ");
                    }
                }
                Console.WriteLine();
            }

            Console.ResetColor();
        }
    }
}