using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalKingdom
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert animal");
            string animal = Console.ReadLine();
            switch (animal)
            {
                case "Cat":
                    Animal cat = new Cat("Pesho", 12);
                    Console.WriteLine($"{cat.MakeNoise()}");
                    Console.WriteLine($"{cat.MakeTrick()}");
                    break;

                case "Dog":
                    Animal dog = new Dog("Gosho", 6);
                    Console.WriteLine($"{dog.MakeNoise()}");
                    Console.WriteLine($"{dog.MakeTrick()}");
                    break;
            }
        }
    }
}
