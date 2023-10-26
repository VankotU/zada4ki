using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSalon
{
    internal class Salon
    {
		private string brand;
		private int age;
		private double price;
		private string color;

		public string Color
		{
			get { return color; }
			set 
			{
				if(string.IsNullOrEmpty(value))
				{
					throw new ArgumentNullException("Cvqt");
				}
				color = value;
			}
		}


		public double Price
		{
			get { return price; }
			set 
			{ 
				if(value > 5000 && value <10000)
				{
                    throw new ArgumentOutOfRangeException("Cena");
                }
				price = value;
			}
		}


		public int Age
		{
			get { return age; }
			set 
			{
				if(value > 10 && value < 15)
				{
                    throw new ArgumentOutOfRangeException("Godinki");
                }
				age = value;
			}
		}


		public string Brand
		{
			get { return brand; }
			set 
			{
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("value");
                }
                brand = value;
			}
		}

		public Salon(string brand, int age, double price, string color)
		{
			this.Brand = brand;
			this.Age = age;
			this.Price = price;
			this.Color = color;
		}

		public void Izhod()
		{
			Console.WriteLine($"marka - {this.brand}: godini - {this.age}: cena - {this.price}: cvqt - {this.color}:");
		}
	}
}
