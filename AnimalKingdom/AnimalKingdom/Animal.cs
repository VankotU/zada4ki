using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalKingdom
{
    public class Animal:IMakeNoise,IMakeTrick
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Animal(string name, int age) 
        {
            this.Name = name;
            this.Age = age;
        }
        public virtual string MakeNoise()
        {
            return $"My name is {Name}. I am {Age} old";
        }
        public virtual string MakeTrick() => "Look at my trick";
    }
}
