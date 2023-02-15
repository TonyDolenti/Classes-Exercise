using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Nissan";
            myCar.Model = "350z";
            myCar.Year = 2006;

            var otherCar = new Car()
            {
                Make = "Subaru",
                Model = "BRZ",
                Year = 2013,
            };

            var nissan = new Car($"Nissan", "GTR", 2009);

            var carList = new List<Car>() { myCar, otherCar, nissan };
            
            foreach(var car in carList)
            {
                Console.WriteLine($"{car.Make} {car.Model} {car.Year}");
            }


        }
    }
}
