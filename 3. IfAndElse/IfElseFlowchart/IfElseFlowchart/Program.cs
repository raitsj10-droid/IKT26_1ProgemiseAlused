namespace IfElseFlowchart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjuta nimi");
            string nimi = Console.ReadLine();

            if (nimi == "Mati")
            {
                Console.WriteLine("Tere Mati");
            }
            else
            {
                Console.WriteLine("Sina ei ole Mati, vaid hoopis " + nimi);
            }
        }
    }
}
