namespace SwitchTöö
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjuta number 1, 2 või 3");

            int what = int.Parse(Console.ReadLine());

            switch (what)
            {
                case 1:
                    Console.WriteLine("Sisesta esimene number mida tahad korrutada");
                    int number1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Sisesta teine number mida tahad korrutada");
                    int number2 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Korrutamise vastus on: {number1} * {number2} = {number1 * number2}");
                    break;

                case 2:
                    Console.WriteLine("Mis on sinu vanus?");
                    int age = int.Parse(Console.ReadLine());
                    Console.WriteLine("Sinu vanus on " + age);
                    break;

                case 3:
                    kolmasm();
                    break;

                default:
                    Console.WriteLine("Sisestasid mingi muu numbri");
                    break;
            }
        }
        static void kolmasm()
        {
            Console.WriteLine("Miau");
        }
    }
}
