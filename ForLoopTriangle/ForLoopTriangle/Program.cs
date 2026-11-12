namespace ForLoopTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tärnidest kolmnurk e poolik püramiid");
            Console.WriteLine("-------------------------------------");
            //\n tähendab uut rida
            Console.WriteLine("\n\n");

            Console.WriteLine("Sisesta ridade arv: ");
            int r = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= r; i++)
            {
                Console.WriteLine();
                for (int a = 0; a < i; a++)
                {
                    Console.Write("*");
                }
            }
        }
    }
}
