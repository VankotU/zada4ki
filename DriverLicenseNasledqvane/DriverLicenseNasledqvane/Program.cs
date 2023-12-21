using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverLicenseNasledqvane
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Driver> listDriver = new List<Driver>()
            {
                new Driver("B12345","12.12.2021",3,"BMW","PB1234CC","Ivajlo Ivanov",2),
                new Driver("HH1345","11.11.2018",4,"Volvo","PB13434CN","Georgi Petrov",1)
            };

            listDriver.ForEach(x=>x.Print());
        }
    }
}
