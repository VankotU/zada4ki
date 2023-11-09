using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarayIncrease
{
    internal class Person
    {
		private string name;
		private int age;
		private double salary;
		
		public double Salary
		{
			get { return salary; }
			set 
			{
                if (value < 1000)
                {
                    throw new ArgumentOutOfRangeException("Salary");
                }
                salary = value;
			}
		}


		public int Age
		{
			get { return age; }
			set 
			{
                if (value < 18 || value > 65)
                {
                    throw new ArgumentOutOfRangeException("Age");
                }
                age = value;
			}
		}


		public  string Name
		{
			get { return name; }
			set 
			{
                if (string.IsNullOrEmpty(value))
                {
                    throw new FormatException("name");
                }
                name = value;
			}
		}

        public Person(string name, int age, double salary)
		{
			this.Name = name;
			this.Age = age;
			this.Salary = salary;
		}

		public void IncreasSalary(double percent)
		{
			if( this.age > 30 )
			{
				this.salary += this.salary * percent / 100;
			}

			else 
			{
                this.salary += this.salary * percent / 200;
            }
		}


		public void Izhod()
		{
			Console.WriteLine($"Ime - {this.name}, Godini - {this.age}, Zaplata - {this.salary}:");
		}
	}
}
