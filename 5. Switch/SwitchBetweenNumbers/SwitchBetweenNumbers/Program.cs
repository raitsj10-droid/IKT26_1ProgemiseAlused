using static System.Net.Mime.MediaTypeNames;

namespace SwitchBetweenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta number:");
            int number = Convert.ToInt32(Console.ReadLine());

            switch (number)
            {
                case >= 0 and <= 100:
                    Console.WriteLine("Sisestasid numbri 0 kuni 100");
                    break;

                case >= 101 and <= 200:
                    Console.WriteLine("Sisestasid numbri 101 kuni 200");
                    break;

                case >= 201 and <= 300:
                    Console.WriteLine("Sisestasid numbri 201 kuni 300");
                    break;

                default:
                    break;
            }
        }
    }
}
