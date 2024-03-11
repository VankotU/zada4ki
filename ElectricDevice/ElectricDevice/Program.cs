using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricDevice
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Laptop> list = new List<Laptop>();
            Console.WriteLine("Count - ");
            int count = int.Parse(Console.ReadLine());
            Laptop laptop;
            for (int i = 0; i < count; i++) 
            {
                var data = Console.ReadLine().Split();
                laptop = new Laptop(int.Parse(data[0]), data[1], int.Parse(data[2]), int.Parse(data[3]));
                list.Add(laptop);
            }
            list.ForEach(x => x.Print());
            Console.WriteLine("1-On, 2-Off");
            int energy = int.Parse(Console.ReadLine());
            switch (energy) 
            {
                case 1:list.ForEach(x => x.On()); break;
                case 2: list.ForEach(x => x.Off()); break;
            }
            foreach (var l in list)
            {
                l.Print();
            }
            list.Sort();
            list.ForEach(x => x.Print());
            ICompare compare = new ICompare();
            list.Sort(compare);
            list.ForEach (x => x.Print());
        }
    }
}
