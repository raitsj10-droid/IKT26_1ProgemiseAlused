namespace SwitchRandomNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //tuleb teha switch, kus esimene case on 10,
            //teine on 20 ja kolmas on 30
            
            int number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 10:
                    Console.WriteLine("kirjutasid 10");
                    break;

                case 20:
                    Console.WriteLine("kirjutasid 20");
                    break;

                case 30:
                    Console.WriteLine("kirjutasid 30");
                    break;

                default:
                    Console.WriteLine("kirjutasid midagi muud: " + number);
                    break;
            }
        }
    }
}
