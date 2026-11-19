namespace WhileDoTriangle
{
    internal class Program
    {
        private static Random _random = new Random();
        private static ConsoleColor GetRandomConsoleColor()
        {
            var consoleColors = Enum.GetValues(typeof(ConsoleColor));
            return (ConsoleColor)consoleColors.GetValue(_random.Next(consoleColors.Length));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("While Do");

            int n = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while (i <= n)
            {
                Console.WriteLine();
                Console.ForegroundColor = GetRandomConsoleColor();
                int j = 1;
                while (j <= i)
                {
                    Console.WriteLine(j + " ");
                    j++;
                }
                i++;
            }
        }
    }
}
