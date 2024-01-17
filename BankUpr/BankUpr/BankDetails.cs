using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankUpr
{
    public class BankDetails
    {
        protected string name;
        protected string address;

        public BankDetails(string name, string address)
        {
            this.name = name;
            this.address = address;
        }

        public virtual void Print()
        {
            Console.WriteLine($"Name of the bank - {name}, Address of the bank - {address}");
        }
    }
}
