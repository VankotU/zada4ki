using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricDevice
{
    public class Laptop:Device, IComparable<Laptop>
    {
        public int ram;
        private int hdd;
        public int Ram
        {
            get { return ram; }
            set { ram = value; }
        }
        public int Hdd
        {
            get { return hdd; }
            set { hdd = value; }
        }
        public Laptop(int power, string model, int ram, int hdd):base(power, model) 
        {
            this.ram = ram;
            this.hdd = hdd;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"{this.ram}, {this.hdd}");
        }
        public override bool On()
        {
            return base.On();
        }
        public override bool Off()
        {
            return base.Off();
        }
        public int CompareTo(Laptop other)
        {
            int comparer;
            comparer = this.Ram.CompareTo(other.Ram);
            if(comparer==0)
                comparer = this.Hdd.CompareTo(other.Hdd);
            return comparer;
        }
    }
}
