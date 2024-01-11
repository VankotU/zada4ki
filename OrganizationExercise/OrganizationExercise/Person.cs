using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationExercise
{
    public class Person:Organization
    {
        protected string namePerson;
        protected int age;
        protected string gender;
        protected string familySituation;
        protected string colorEyes;
        protected string colorHair;

        public Person(string name,string cityName,string namePerson, int age, string gender, string familySituation, string colorEyes, string colorHair):base(name, cityName)
        {
            this.namePerson = namePerson;
            this.age = age;
            this.gender = gender;
            this.familySituation = familySituation;
            this.colorEyes = colorEyes;
            this.colorHair = colorHair;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"{namePerson}, {age}, {gender}, {familySituation}, {colorEyes}, {colorHair}");
        }
    }
}
