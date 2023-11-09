using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarayIncrease
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                Console.WriteLine("Kolko choveka shte vuvejdash - ");
                int n = int.Parse(Console.ReadLine());

                Console.WriteLine("Vuvedi danni na rabotnika - ");
                List <Person> list = new List<Person>(); 

                for(int i = 0; i < n; i++)
                {
                    var data = Console.ReadLine().Split();
                    Person w1 = new Person(data[0], int.Parse(data[1]), double.Parse(data[2]));
                    list.Add(w1);
                }

                foreach(var item in list) 
                {
                    item.Izhod();
                }

                Console.WriteLine("Vuvedi uvelichenie na zaplata - ");
                double percent = double.Parse(Console.ReadLine());

                foreach(var item in list)
                {
                    item.IncreasSalary(percent);
                }

                foreach (var item in list)
                {
                    item.Izhod();
                }
            }

            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
