namespace ForLoopDiamond
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //teha for loopiga püramiid

            Console.WriteLine("Sisesta teemanti suurus");
            Console.WriteLine("\n\n");
            int r = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= r; i++)
            {
                for (int j = 1; j <= r - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = r - 1; i >= 1; i--)
            {
                for (int j = 1; j <= r - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
