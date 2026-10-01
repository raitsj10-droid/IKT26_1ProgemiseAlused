namespace IfElseColours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Värvide valikuks on: red, blue, green ja white. " +
                "Sisesta värv");

            Console.WriteLine("Sisesta värv");
            //kirjuta konsooli tekst ja vajuta enter
            string color = Console.ReadLine();

            //see kontrollib, kas on punane värv
            //kui kasutad if ja else, siis esimene kontroll on if
            //ja järgneb else if ning kõige viimane on alati else
            if (color == "red")
            {
                Console.WriteLine("See on punane");
            }
            else if (color == "blue")
            {
                Console.WriteLine("See on sinine");
            }
            else if (color == "green")
            {
                Console.WriteLine("See on roheline");
            }
            else if (color == "white")
            {
                Console.WriteLine("See on valge");
            }
            else
            {
                Console.WriteLine("Kahtlane värv");
            }
        }
    }
}
