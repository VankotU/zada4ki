using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalKingdom2
{
    public class Dog:IAnimal
    {
        public string MakeNoise()
        {
            return "Woof";
        }
        public string MakeTrick()
        {
            return "golqmo trik4e fur u";
        }
        public void Perform()
        {
            Console.WriteLine(MakeNoise());
            Console.WriteLine(MakeTrick());
        }
    }
}
