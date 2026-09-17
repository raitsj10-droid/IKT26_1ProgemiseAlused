using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace IfAndElseFootNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("If and else footnumber");
            
            string number = Console.ReadLine();

            int numberInt = int.Parse(number);

            if (numberInt < 30)
            {
                Console.WriteLine("liiga väike");
            }
            else if (numberInt > 48)
            {
                Console.WriteLine("liiga suur");
            }
            else if (numberInt > 44)
            {
                Console.Beep();
                Console.WriteLine("beep");
                Console.WriteLine(numberInt);
            }
            else if (numberInt > 38)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine(numberInt);
            }
            else if (numberInt > 33)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine(numberInt);
            }
            else if (numberInt > 29)
            {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(numberInt);
            }
        }
    }
}
