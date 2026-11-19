namespace SwitchRandomNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Täringu viskamise mäng");
            
            //Random genereerib iga kord suvalise nr 1-6
            int cube = new Random().Next(1, 7);

            //kasuta switchi ja iga juhtum tuleb ära printida, mis number tuli
            switch (cube)
            {
                case 1:
                    Console.WriteLine("Veeretasid 1");
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 2:
                    Console.WriteLine("Veeretasid 2");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case 3:
                    Console.WriteLine("Veeretasid 3");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case 4:
                    Console.WriteLine("Veeretasid 4");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                    break;
                case 5:
                    Console.WriteLine("Veeretasid 5");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                case 6:
                    Console.WriteLine("Veeretasid 6");
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                default:
                    Console.WriteLine("ERROR");
                    break;
            }
        }
    }
}
