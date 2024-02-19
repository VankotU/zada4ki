using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalKingdom
{
    public class Dog:Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Dog(string name, int age) : base(name, age)
        {
            this.Name = name;
            this.Age = age;
        }
        public virtual string MakeNoise()
        {
            return "Woof";
        }
        public virtual string MakeTrick() => "Hold my paw human!";
    }
}
