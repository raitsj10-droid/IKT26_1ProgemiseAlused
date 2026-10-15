using System.Globalization;

namespace SwitchCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sistesta esimene number");
            float number1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Vali tehe: +, -, *, /, ^");
            string tegevus = Console.ReadLine();

            Console.WriteLine("Sisesta teine number");
            float number2 = float.Parse(Console.ReadLine());

            switch (tegevus)
            {
                case "+":
                    float vastus = number1 + number2;
                    Console.WriteLine($"Liitmise tehe: {number1} + {number2} = {vastus} ");
                    break;

                case "-":
                    float vastus2 = number1 - number2;
                    Console.WriteLine($"Lahutamise tehe: {number1} - {number2} = {vastus2} ");
                    break;

                case "*":
                    float vastus3 = number1 * number2;
                    Console.WriteLine($"Korrutamise tehe: {number1} * {number2} = {vastus3} ");
                    break;

                case "/":
                    if (number2 == 0)
                    {
                        Console.WriteLine("Nulliga ei saa jagada");
                        break;
                    }
                    else
                    {
                        float vastus4 = number1 / number2;
                        Console.WriteLine($"Jagamise tehe: {number1} / {number2} = {vastus4} ");
                    }
                    break;

                case "^":
                    float vastus5 = (float)Math.Pow(number1, number2);
                    Console.WriteLine($"Astendamise tehe: {number1} ^ {number2} = {vastus5} ");
                    break;

                default:
                    Console.WriteLine("Ei tahtnud midagi teha");
                    break;

            }
        }
    }
}
