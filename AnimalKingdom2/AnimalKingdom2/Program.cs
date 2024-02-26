using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalKingdom2
{
    public class Program
    {
        static void Main(string[] args)
        {
            IAnimal cat = new Cat();
            IAnimal dog = new Dog();

            Trainer t1 = new Trainer(cat);
            Trainer t2 = new Trainer(dog);

            t1.Make();
            t2.Make();
        }
    }
}
