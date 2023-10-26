using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSalon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Vuvedi broika - ");
                int n = int.Parse(Console.ReadLine());

                Console.Write("Vuvedi danni za kolata - ");
                List<Salon> list = new List<Salon>();

                for (int i = 0; i < n; i++)
                {
                    var data = Console.ReadLine().Split();
                    Salon s1 = new Salon(data[0], int.Parse(data[1]), double.Parse(data[2]), data[3]);
                    list.Add(s1);
                }

                foreach (var s in list)
                {
                    s.Izhod();
                }
            }

            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
