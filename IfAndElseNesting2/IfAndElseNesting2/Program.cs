namespace IfAndElseNesting2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("If and else nesting 2");

            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                if (input == 1)
                {
                    Console.WriteLine("kirjutasid 1");
                    else if (input == 2)
                        Console.WriteLine("kirjutasid 2");
                }
                else (input == 3);
                {
                    Console.WriteLine("kirjutasid 3");
                }
            }
            else if (input == 4)
            {
                Console.WriteLine("kirjutasid 4");
            }
            else (input == 5);
            {
                Console.WriteLine("kirjutasid 5");
            }
        }
    }
}
