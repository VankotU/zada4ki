using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverLicenseNasledqvane
{
    public class License
    {
        protected string nomer;
        protected string date;
        protected int validation;

        protected int Validation
        {
            get { return validation; }
            set
            {
                if (value > 5)
                {
                    throw new ArgumentOutOfRangeException("Ne validno");
                }
                this.validation = value;
            }
        }

        public License(string nomer, string date, int validation)
        { 
            this.nomer = nomer;
            this.date = date;
            this.validation = validation;
        }

        public virtual void Print()
        {
            Console.Write($"{nomer} {date} {validation}");
        }
    }
    
}
