using System.Security.Cryptography.X509Certificates;

namespace Classes
{
     class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Ford";
            myCar.Model = "Fusion";
            myCar.Year = 2019;

            Console.WriteLine($"{myCar.Make}, {myCar.Model}, {myCar.Year}");
        }
    }
}
