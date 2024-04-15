using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyBirthDay
{
    public class Individuals:IPrint
    {
        private string age;
        private string name;
        private int id;

        public string Age
        {
            get { return age; }
            set { age = value; }
        }
        public int Id
        { 
            get { return id; } 
            set {  id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Individuals(string age, string name, int id) 
        {
            this.Age = age;
            this.Name = name;
            this.Id = id;
        }
        public virtual void Print()
        {
            Console.WriteLine($"Pet - {Name}, {Age}, {Id}");
        }
    }
}
