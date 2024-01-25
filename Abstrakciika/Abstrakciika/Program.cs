using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrakciika
{
    public class Program
    {
        static void Main(string[] args)
        {
            Figura f1 = new Square(5);
            f1.InfoFigura();
            Console.WriteLine($"Area of square is: {f1.Area()}");

            Figura f2 = new Rectangle(5, 3);
            f2.InfoFigura();
            Console.WriteLine($"Area of rectangle is: {f2.Area()}");
        }
    }
}
