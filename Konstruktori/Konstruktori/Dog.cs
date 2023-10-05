using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruktori
{
    internal class Dog
    {
        private int age;
        private string name;
        private double kg;

        public int Age
        {
            get { return age; } 
            set { age = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Kg
        {
            get { return kg; }
            set { kg = value; }
        }

        public Dog()
        {
            this.age = 8;
            this.name = "Rex";
            this.kg = 50;
        }

        public Dog(int age):this()
        {
            this.age = age;
        }

        public Dog(int age, string name):this(age)
        {
            this.name = name;
        }

        public Dog(int age, string name, double kg):this(age,name)
        {
            this.kg = kg;
        }

        public void Print()
        {
            Console.WriteLine($"{age} {name} {kg}");
        }
    }
}
