namespace IfAndElseNesting3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----If and else nesting 2-----");

            Console.WriteLine("Sisesta number:");

            string input = Console.ReadLine();

            if (int.TryParse(input, out int input))
            {
                Console.WriteLine(input);
            }
            else
            {
                Console.WriteLine("mingi imelik");
            }
        }
    }
}
