using System.Security.Cryptography.X509Certificates;

namespace Classes
{
     class Program
    {
        static void Main(string[] args)
        {
            var fusion = new Car();
            fusion.Make = "Ford";
            fusion.Model = "Fusion";
            fusion.Year = 2019;

            Console.WriteLine($"{fusion.Make}, {fusion.Model}, {fusion.Year}");
        }
    }
}
