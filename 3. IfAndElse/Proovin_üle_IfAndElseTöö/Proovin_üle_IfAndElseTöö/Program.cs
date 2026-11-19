namespace Proovin_üle_IfAndElseTöö
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjuta oma pikkus sentimeetrites:");

            string pikkusühik = Console.ReadLine();
            int pikkus = int.Parse(pikkusühik);

            if (pikkus >= 40 && pikkus <= 80)
            {
                Console.ForegroundColor = ConsoleColor.Blue; //Värvid on, et saaks eristada neid numbrite vahemikke
                Console.WriteLine("Sinu pikkus on: " + pikkus);
            }
            else if (pikkus >= 81 && pikkus <= 130)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Sinu pikkus on: " + pikkus);
            }
            else if (pikkus >= 131 && pikkus <= 170)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Sinu pikkus on: " + pikkus);
            }
            else if (pikkus > 170)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Sinu pikkus on: " + pikkus);
            }
            else
            {
                Console.WriteLine("Mingi imelik number");
            }
        }
    }
}
