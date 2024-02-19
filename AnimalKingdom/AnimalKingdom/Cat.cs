using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalKingdom
{
    public class Cat:Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Cat(string name, int age) : base(name, age)
        {
            this.Name = name;
            this.Age = age;
        }
        public virtual string MakeNoise()
        {
            return "Meow";
        }

        public virtual string MakeTrick() => "No trick for you i'm too lazy";
    }
}
