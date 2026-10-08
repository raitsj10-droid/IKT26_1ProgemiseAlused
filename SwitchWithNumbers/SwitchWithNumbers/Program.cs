namespace SwitchWithNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta number");

            int number = int.Parse(Console.ReadLine());
            //Teie töö on teha switch rakendus,
            //kus on kolm case

            switch (number)
            {
                case 1:
                    Console.WriteLine("Siestasid 1");
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 2:
                    Console.WriteLine("sisestasid 2");
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 3:
                    Console.WriteLine("sisestasid 3");
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                default:
                    Console.WriteLine("Mingi muu number");
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
            }
        }
    }
}
