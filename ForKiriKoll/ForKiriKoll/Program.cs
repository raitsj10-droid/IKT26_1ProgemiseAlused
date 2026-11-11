namespace ForKiriKoll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Eelnevaid teadmisi kasutades kirjuta programm, mis väljastaks:
            //kill - koll
            //kill - koll
            //killadi - koll
            //kill - koll
            //kill - koll
            //killadi - koll
            //kill - koll
            //kill - koll
            //killadi - koll
            //for loopi sees peab olema for loop
            //peab saama sisestada arvu, mitu korda soovib väljundit korrata
            //iga kord kui hakkab väljundit kordama, siis näitab rea numbrit

            int r = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= r; i++)
            {
                Console.WriteLine("See on rea arv {0}", + i);
                for (int e = 0; e < 2; e++)
                {
                    Console.WriteLine("kill - koll");
                }
                Console.WriteLine("killadi - koll");
            }
        }
    }
}
