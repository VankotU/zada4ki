using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerHW
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n = int.Parse(Console.ReadLine());

                List <DiamondMiner> list = new List<DiamondMiner>();
                
                for (int i = 0; i < n; i++)
                {
                    var data = Console.ReadLine().Split();
                    DiamondMiner d1 = new DiamondMiner(data[0], data[1], int.Parse(data[2]));
                    list.Add(d1);
                }
                foreach(var d in list)
                {
                    d.Izhod();
                }

                list.OrderByDescending(x => x.TotalNumber).ToList().ForEach(y=>Console.WriteLine($"{y.TotalNumber}"));
                list.Where(z => z.Name == "A").ToList().ForEach(h => Console.WriteLine($"{h.Name}"));
                
            }


            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

           
        }
    }
}
