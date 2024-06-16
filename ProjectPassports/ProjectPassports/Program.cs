using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPassports
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Insert number - ");
                int n = int.Parse(Console.ReadLine());

                List<DateInformation> list = new List<DateInformation>();

                for (int i = 0; i < n; i++)
                {
                    Console.Write("Insert data for the passport - ");
                    var data = Console.ReadLine().Split();
                    DateInformation d1 = new DateInformation(data[0], int.Parse(data[1]), int.Parse(data[2]),int.Parse(data[3]),data[4],data[5]);
                    list.Add(d1);
                }

                foreach (var d in list)
                {
                    d.Print();
                }
                list.OrderByDescending(x => x.Age).ToList().ForEach(y => Console.WriteLine($"{y.Name}, {y.Age}, {y.Egn}, {y.NumberPassport}, {y.DateOfCreation}, {y.DateOfExpiring}"));
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
