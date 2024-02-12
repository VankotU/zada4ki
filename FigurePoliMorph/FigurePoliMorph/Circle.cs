using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurePoliMorph
{
    public class Circle:Shape
    {
        private double radius;
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        public Circle(double radius)
        {
            this.Radius = radius;
        }
        public override double CalculatePerimeter()
        {
            return 2*Math.PI*radius;
        }
        public override double CalculateArea()
        {
            return Math.PI*Math.Pow(radius,2);
        }
        public override string Draw()
        {
            return base.Draw()+"Circle";
        }
    }
}
