using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyBirthDay
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("number - ");
            int count = int.Parse(Console.ReadLine());
            Console.Write("Data - ");
            List<Individuals> list = new List<Individuals>();
            for (int i = 0; i < count; i++) 
            {
                var data = Console.ReadLine().Split();
                Individuals a = new Individuals(data[0], data[1],int.Parse(data[2]));
                list.Add(a);
            }
            foreach (var item in list)
            {
                item.Print();
            }
            IndividualComparator comparator = new IndividualComparator();
            list.Sort(comparator);
            Console.WriteLine(string.Join(Environment.NewLine, list.Select(x=>x.Id)));
        }
    }
}
