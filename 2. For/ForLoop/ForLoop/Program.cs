namespace ForLoop
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
            Console.WriteLine("For Loop");

            int loop = 100000;

            //int i on muutuja määratlemine ja selle väärtus on 0
            //i < loop iga kord võrdleb loop muutuja, et kas on suurem i-st
            //i++ liidab iga kord ühe korra juurde e sama hea, kui i + 1

            for (int i = 1; i < loop; i++)
            {
                Console.ForegroundColor = GetRandomConsoleColor();
                Console.WriteLine("Loop " + i);
                Thread.Sleep(100);
                Console.Beep();
            }
        }
    }
}
