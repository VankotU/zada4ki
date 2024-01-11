using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationExercise
{
    public class DataPerson:Person
    {
        protected string address;
        protected int phoneNumber;

        public DataPerson(string address, int phoneNumber, string name, string cityName, string namePerson, int age, string gender, string familySituation, string colorEyes, string colorHair) : base(name, cityName, namePerson, age, gender, familySituation, colorEyes, colorHair)
        {
            this.address = address;
            this.phoneNumber = phoneNumber;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"{address}{phoneNumber}");
        }
    }
}
