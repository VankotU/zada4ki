using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverLicenseNasledqvane
{
    public class Driver:Car
    {
        protected string nameDriver;
        protected int countAutos;

        public Driver(string nomer, string date, int validation, string regNumber, string model, string nameDriver, int countAutos) : base(nomer, date, validation, regNumber, model)
        {
            this.nameDriver = nameDriver;
            this.countAutos = countAutos;
        }

        public override void Print()
        {
            Console.WriteLine($"{nameDriver} {countAutos}");
        }
    }
}
