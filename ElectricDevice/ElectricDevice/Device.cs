using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricDevice
{
    public class Device:IPrint, IDevices
    {
		private int power;
		private string model;
       /* public int Power
        {
            get { return power; }
            set { power = value; }
        }
        public string Model
		{
			get { return model; }
			set { model = value; }
		}*/
        public Device(int power, string model) 
        {
            this.power = power;
            this.model = model;
        }
        public virtual bool On()
        {
            Console.WriteLine("On!");
            return true;
        }
        public virtual bool Off()
        {
            Console.WriteLine("Off!");
            return true;
        }
        public virtual void Print()
        {
            Console.WriteLine($"{this.power}, {this.model}");
        }
	}
}
