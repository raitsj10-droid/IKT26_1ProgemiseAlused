namespace ForLoopEndless
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //teha for loopiga lõputu tsükkel,
            //mis prindib konsooli: i väärtus on number
            short i = 1;

            for ( ; ; )
            {
                Console.WriteLine("i väärtus on " + i);
                i++;
                
                if (i > 10)
                {
                    break;
                }
            }
        }
    }
}
