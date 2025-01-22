namespace Liikennelaskenta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kuinka monta autoa on? ");
            int autot = int.Parse(Console.ReadLine());
            int punainen = 0, vihreä = 0, musta = 0, lasketut = 0;
            
            while (lasketut < autot) {
                Console.WriteLine("Mikä on auton väri? ");
                string väri = Console.ReadLine();
                
                if (väri == "punainen") 
                {
                    punainen++;
                    lasketut++;
                }
                else if (väri == "musta")
                {
                    musta++;
                    lasketut++;
                }
                else if (väri == "vihreä")
                {
                    vihreä++;
                    lasketut++;
                }
            }
            Console.WriteLine("Kaikki autot laskettu");
            Console.WriteLine($"Punaisia autoja on {punainen}");
            Console.WriteLine($"Mustia autoja on {musta}");
            Console.WriteLine($"Vihreitä autoja on {vihreä}");
        }
    }
}
