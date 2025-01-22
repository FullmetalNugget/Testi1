using System;

class Program
{
    static void Main()
    {
        Console.Write("Anna vihollisen x-koordinaatti: ");
        int x = int.Parse(Console.ReadLine());

        Console.Write("Anna vihollisen y-koordinaatti: ");
        int y = int.Parse(Console.ReadLine());

        Console.WriteLine(GetDirection(x, y));
    }

    static string GetDirection(int x, int y)
    {
        if (x == 0 && y == 0) return "Vihollinen ei ole koordinaatissa (0, 0).";
        if (x == 0) return y > 0 ? "Vihollinen tulee pohjoisesta." : "Vihollinen tulee etelästä.";
        if (y == 0) return x > 0 ? "Vihollinen tulee idästä." : "Vihollinen tulee lännestä.";

        if (x > 0 && y > 0) return "Vihollinen tulee koillisesta.";
        if (x < 0 && y > 0) return "Vihollinen tulee luoteesta.";
        if (x < 0 && y < 0) return "Vihollinen tulee lounaasta.";
        if (x > 0 && y < 0) return "Vihollinen tulee kaakosta.";

        return "";
    }
}