namespace ForDiceGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Random random = new Random();

            int playerScore = 0;
            int computerScore = 0;
            Console.WriteLine("Mitu vooru");
            int roundScore = Convert.ToInt32(Console.ReadLine());

            for (int round = 1; round <= roundScore; round++)
            {
                Console.WriteLine();
                Console.WriteLine($"Voor {round}. Vajuta Enter, et täringut veeretada");
                Console.ReadLine();

                int playerRoll = random.Next(1, 7);
                int computerRoll = random.Next(1, 7);

                Console.WriteLine($"Sinu number: {playerRoll}");
                Console.WriteLine($"Arvuti number: {computerRoll}");

                if (playerRoll > computerRoll)
                {
                    Console.WriteLine("Sina võitsid vooru");
                    playerScore++;
                }
                else if (playerRoll < computerRoll)
                {
                    Console.WriteLine("Arvuti võitis vooru");
                    computerScore++;
                }
                else
                {
                    Console.WriteLine("Voor jäi viiki");
                }
            }

            Console.WriteLine("\n");
            Console.WriteLine("Mäng läbi!");

            if (playerScore > computerScore)
            {
                Console.WriteLine("Sina võitsid kogu mängu");
            }
            else if (playerScore < computerScore)
            {
                Console.WriteLine("Arvuti võitis kogu mängu");
            }
            else
            {
                Console.WriteLine("Te jäite viiki");
            }
            Console.WriteLine($"Sina võitsid {playerScore} mängu");
            Console.WriteLine($"Arvuti võitis {computerScore} mängu");
            Console.WriteLine($"Viiki jäi {roundScore - (playerScore+computerScore)} mängu");
        }
    }
}
