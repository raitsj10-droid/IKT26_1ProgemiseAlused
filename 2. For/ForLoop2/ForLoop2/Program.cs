namespace ForLoop2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta kõrgus (vähemalt 3):");
            if (!int.TryParse(Console.ReadLine(), out int height) || height < 3)
            {
                Console.WriteLine("Sisesta täisarv: ");
                return;
            }

            for (int row = 1; row <= height; row++)
            {

                for (int empty = 1; empty <= height - row; empty++)
                {
                    Console.Write(" ");
                }

                for (int location = 1; location <= 2 * row - 1; location++)
                {
                    bool thing =
                        (row == 2 && location == 1) || // ||- see on või operaator ehk üks nõue peab olema täidetud
                        (row == height - 1 && location == 2 * row - 1) ||
                        (row == height && location == row);

                    //ternary operaator: muutuja ? (kaks valikut peale seda)
                    // kui esimene valik on vale, siis vali teine e
                    //kui ei tule o-d, siis pane *
                    if (thing == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("O");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("*");
                    }
                }

                Console.WriteLine();
            }

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            for (int row = 1; row <= 3; row++)
            {
                for (int empty = 1; empty < height; empty++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine("***");
            }
            Console.ResetColor();
        }
    }
}
