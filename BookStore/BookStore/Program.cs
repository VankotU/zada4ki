using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kolko knigi?");
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine("Danni za knigite?");
            List<Book> list = new List<Book>();
            for (int i = 0; i < count; i++) 
            {
                var data = Console.ReadLine().Split();
                Book b = new Book(data[0], data[1], int.Parse(data[2]));
                list.Add(b);
            }
            foreach (var book in list)
            {
                book.Print();
            }
            BookComparator comparator = new BookComparator();
            list.Sort(comparator);
            Console.WriteLine(string.Join(Environment.NewLine, list.Select(x=>x.Year)));
        }
    }
}
