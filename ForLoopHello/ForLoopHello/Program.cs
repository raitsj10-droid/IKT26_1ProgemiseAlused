namespace ForLoopHello
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //teha konsoolirakendus, kus kasutad for loopi
            //kolm korda näidatakse Tere tulemast ja lõpus on reanumber
            //kasutaja ei tohi sisestada midagi

            int e = 3;
            
            for (int i = 0; i < e; i++)
            {
                Console.WriteLine("tere tulemast " + i);
            }
        }
    }
}
