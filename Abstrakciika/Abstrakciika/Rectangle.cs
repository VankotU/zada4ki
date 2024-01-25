using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Abstrakciika
{
    public class Rectangle:Figura
    {
        private double size2;
        public double Size2
        {
            get { return size2; }
            set { size2 = value; }
        }
        public Rectangle(double size1, double size2):base(size1)
        {
            this.size2 = size2;
        }

        public override double Area()
        {
            return size1 * size2;
        }

        public override void InfoFigura()
        {
            base.InfoFigura();
            Console.WriteLine($"Size 2 = {size2}");
        }
    }
}
