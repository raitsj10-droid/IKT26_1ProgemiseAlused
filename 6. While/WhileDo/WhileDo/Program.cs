namespace WhileDo
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

            int nr = int.Parse(Console.ReadLine());
            int i = 1;
            do
            {
                Console.WriteLine(i);
                Console.ForegroundColor = GetRandomConsoleColor();
                //++ liidab ühe numbri juurde eelnevale
                i++;
            } while (i <= nr);
        }
    }
}
