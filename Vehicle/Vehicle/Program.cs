using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Car> listCar = new List<Car>()
            {
                new Car("Mercedes", 3000, 2000, "RP4389CC"),
                new Car("BMW", 4500, 1998, "PB9087RR"),
                new Car("Lada", 2000, 1987, "OV9134CR"),
                new Car("Scania", 15000, 2010, "PA8645KL"),
            };

            listCar.Where(x=>x.Price>2999.99).ToList().ForEach(x=>x.Izhod());
            listCar.OrderByDescending(x=>x.Model).ThenBy(x=>x.Age).Take(3).ToList().ForEach(x=>Console.WriteLine(x.ToString()));
            double min = listCar.Select(x=>x.Price).Min();
            int maxYear = listCar.Select(x => x.Age).Min();

            Console.WriteLine($"minimal price - {min:f2}");
            Console.WriteLine($"oldest year - {maxYear}");


        }
    }
}
