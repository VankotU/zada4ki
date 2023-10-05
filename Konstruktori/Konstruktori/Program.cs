using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruktori
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog();
            dog1.Print();

            Console.Write("Vuvedi godini - ");
            Dog dog2 = new Dog(int.Parse(Console.ReadLine()));
            dog2.Print();

            Console.Write("Vuvedi ime,godini - ");
            Dog dog3 = new Dog(int.Parse(Console.ReadLine()), Console.ReadLine());
            dog3.Print();

            Console.Write("Vuvedi ime,godini - ");
            Dog dog4 = new Dog(int.Parse(Console.ReadLine()), Console.ReadLine(), double.Parse(Console.ReadLine()));
            dog4.Print();

            List <Dog>izhod = new List<Dog> {dog1, dog2, dog3, dog4 };
        }
    }
}
