namespace MaaKalkulaator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maa ja mündid");

            double coinDiameter = 25.75; //mm
            double earthRadius = 6378000000.0; //mm

            double ümbermõõt = earthRadius * 2.0 * Math.PI;
            double answer = ümbermõõt / coinDiameter;
            Console.WriteLine($"Maa ümbermõõt on {ümbermõõt} mm");
            Console.WriteLine($"Mündi diameeter on {coinDiameter} mm");
            Console.WriteLine($"Järjestikku mahub {answer:N0} münti ümber maa");
        }
    }
}
