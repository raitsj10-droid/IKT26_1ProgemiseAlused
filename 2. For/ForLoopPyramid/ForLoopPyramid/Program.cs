namespace ForLoopPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Loome tärnidest püramiidid");
            Console.WriteLine("--------------------------");
            Console.WriteLine("\n");

            Console.WriteLine("Sisesta suurus: ");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            for (int i = 1; i <= r; i++)
            {
                for (int a = 1; a < r - i + 1; a++)
                {
                    Console.Write(" ");
                }
                for (int d = 1; d <= i; d++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            for (int f = r - 1; f >= 1; f--)
            {
                for (int w = 0; w <= r - f; w++)
                {

                }
            }
        }
    }
}
