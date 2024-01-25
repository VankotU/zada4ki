using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrakciika
{
    abstract public class Figura
    {
        protected double size1;
        public Figura(double size1)
        {
            this.size1 = size1;
        }

        public abstract double Area();
        public virtual void InfoFigura()
        {
            Console.WriteLine($"Size 1 = {size1}");
        }
    }
}
