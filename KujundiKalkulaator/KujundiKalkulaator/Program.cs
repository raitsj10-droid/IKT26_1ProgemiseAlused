namespace KujundiKalkulaator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //andmed
            int ringR = 3;
            int squareW = ringR * 2;

            //ruudu arvutused
            int squareS = squareW * squareW;
            int squareP = squareW * 4;
            
            //ruudu arvutuste näitamine
            Console.WriteLine("Ruudu pindala on " + squareS);
            Console.WriteLine("Ruudu ümbermõõt on " + squareP);
            
            //ringi arvutused
            double ringS = Math.PI * Math.Pow(ringR, 2);
            double ringP = 2 * Math.PI * ringR;

            //ringi arvutuste näitamine
            Console.WriteLine($"Ringi pindala on {ringS} ja ümardatult {ringS:N0}");
            Console.WriteLine($"Ringi ümbermõõt on {ringP} ja ümardatult {ringP:N0}");
        }
    }
}
