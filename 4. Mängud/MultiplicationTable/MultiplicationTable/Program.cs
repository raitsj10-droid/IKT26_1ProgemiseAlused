namespace MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Korrutustabel");

            int r, i, e;

            Console.WriteLine("Sisesta tabelisse number, mis on viimane korrutis");
            r = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= 10; i++)
            {
                for (e = 1; e <= r; e++)
                {
                    if (e <= r - 1)
                    {
                        Console.Write("{0}*{1} = {2} \t", e, i, i * e);
                    }
                    else
                    {
                        Console.Write("{0}*{1} = {2} \t", e, i, i * e);
                    }                    
                }

                Console.Write("\n");
            }                                    
        }
    }
}
