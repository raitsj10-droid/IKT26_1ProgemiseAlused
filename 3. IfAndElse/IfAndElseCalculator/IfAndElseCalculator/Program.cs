namespace IfAndElseCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Esimene number");
            float nr1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Vali tehe: +, -, *, /, ^");
            string tehe = Console.ReadLine();

            Console.WriteLine("Teine number");
            float nr2 = float.Parse(Console.ReadLine());

            if (tehe == "+")
            {
                Console.WriteLine($"Liitmise tehe: {nr1} + {nr2} = {nr1 + nr2}");
            }
            else if (tehe == "-")
            {
                Console.WriteLine($"Lahutamise tehe: {nr1} - {nr2} = {nr1 - nr2}");
            }
            else if (tehe == "*")
            {
                Console.WriteLine($"Korrutamise tehe: {nr1} * {nr2} = {nr1 * nr2}");
            }
            else if (tehe == "/")
            {
                if (nr2 == 0)
                {
                    Console.WriteLine("Nulliga ei saa jagada");
                }
                else
                {
                    Console.WriteLine($"Jagamise tehe: {nr1} / {nr2} = {nr1 / nr2}");
                }
            }
            else if (tehe == "^")
            {
                Console.WriteLine($"Astendamise tehe: {nr1} ^ {nr2} = {Math.Pow(nr1, nr2)}");
            }
            else
            {
                Console.WriteLine("Ei teinud midagi");
            }
        }
    }
}
