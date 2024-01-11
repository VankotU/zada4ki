using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationExercise
{
    public class Organization
    {
        protected string name;
        protected string cityName;

        public Organization(string name, string cityName) 
        {
            this.name = name;
            this.cityName = cityName;   
        }

        public virtual void Print()
        {
            Console.WriteLine($"Name of the organization -{name}, Name of the city - {cityName} "  );
        }
    }
}
