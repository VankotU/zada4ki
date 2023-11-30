using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    public class Car
    {
		private string model;
		private double price;
		private int age;
		private string number;

		public string Number
		{
			get { return number; }
			set { number = value; }
		}


		public int Age
		{
			get { return age; }
			set { age = value; }
		}


		public double Price
		{
			get { return price; }
			set { price = value; }
		}


		public string Model
		{
			get { return model; }
			set { model = value; }
		}

		public Car(string model,double price,int age,string number) 
		{
			this.Age = age; 
			this.Price=price;
			this.Number = number;
			this.Model = model;
		}

		public void Izhod()
		{
			Console.WriteLine($"Model - {this.model}, Price - {this.price}, Age - {this.age}, Number{this.number}");
		}
	}
}
