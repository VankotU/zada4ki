using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurePoliMorph
{
    public class Trapezium:Shape
    {
		private double a;
		private double b;
        private double c;
		public double A
		{
			get { return a; }
			set { a = value; }
		}
        public double B
        {
            get { return b; }
            set { b = value; }
        }
        public double C
        {
            get { return c; }
            set { c = value; }
        }
        public Trapezium(double a, double b, double c)
        {
            this.A = a; 
            this.B = b; 
            this.C = c;
        }
        public override double CalculatePerimeter()
        {
            return 2*(a+b);
        }
        public override double CalculateArea()
        {
            return ((a+b)/2)*c;
        }
        public override string Draw()
        {
            return base.Draw()+"Trapezium";
        }
    }
}
