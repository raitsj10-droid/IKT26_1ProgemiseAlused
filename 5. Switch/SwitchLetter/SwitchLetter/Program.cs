using System.Linq.Expressions;

namespace SwitchLetter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Meetodi valimine");
            
            //Tee kolm meetodit, mis teevad järgmist:
            //esimene ütleb auh
            //teine ütleb, et tahan magada
            //kolmas ütle, et tahan õppida
            //Need tuleb esile kutsuda numbri valikuga
            //Tuleb kasutada switchi 
            //Tuleb teha menüü, kus kasutaja saab valida,
            //millist meetodit ta tahab esile kutsuda

            //switchi kasutades:

            //int method = Convert.ToInt32(Console.Readline())

            //switch (method)
            //{
            //  case 1:
            //      Esimene();
            //      break;
            //  case 2:
            //      Teine();
            //      break;
            //  case 3:
            //      Kolmas();
            //      break;
            //  default:
            //      Console.Writeline("Ei soovinud midagi")
            //}
            Console.WriteLine("kirjuta 1, 2 või 3, et esile tuua meetod");

            string method = Console.ReadLine();

            if (method == "1")
            {
                Esimene();
            }
            else if (method == "2")
            {
                Teine();
            }
            else if (method == "3")
            {
                Kolmas();
            }
            else
            {
                Console.WriteLine("ei soovinud midagi");
            }
        }
        static void Esimene()
        {
            Console.WriteLine("auh");
        }
        static void Teine()
        {
            Console.WriteLine("tahan magada");
        }
        static void Kolmas()
        {
            Console.WriteLine("tahan õppida");
        }
    }
}
