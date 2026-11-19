namespace IfAndElseNesting4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----If and else nesting 2-----");

            Console.WriteLine("Sisesta number:");
            
            //konsool loeb ainult stringi andmetüüpe
            //string number = Console.ReadLine(); <--õpetaja tegi nii
            //muudame stringi int andmetüübiks ja kasutame Parset
            //int numberInt = int.Parse(number); <--õpetaja tegi nii
            
            int number = Convert.ToInt32(Console.ReadLine());

            if (number < 20)
            {
                Console.WriteLine("number on väiksem kui 20");
            }
            else if (number > 20)
            {
                if (number < 30)
                {
                    Console.WriteLine("vahemikus 20 ja 30");
                }
                else
                {
                    Console.WriteLine("suurem kui 30");
                }
            }
            else
            {
                Console.WriteLine("mingi imelik");
            }
        }
    }
}
