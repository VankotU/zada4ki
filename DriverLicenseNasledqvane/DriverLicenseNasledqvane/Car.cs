using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverLicenseNasledqvane
{
    public class Car:License
    {
        protected string regNumber;
        protected string model;
        public Car(string nomer, string date, int validation, string regNumber, string model):base(nomer, date, validation)
        {
            this.regNumber = regNumber;
            this.model = model;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"{regNumber}{model}");
        }
    }
}
