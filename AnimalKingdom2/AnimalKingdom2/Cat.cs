using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalKingdom2
{
    public class Cat:IAnimal
    {
        public string MakeNoise()
        {
            return "miauw";
        }
        public string MakeTrick()
        {
            return "no trik4e fur u";
        }
        public void Perform()
        {
            Console.WriteLine(MakeNoise());
            Console.WriteLine(MakeTrick());
        }
    }
}
