using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurePoliMorph
{
    public class Rectangle:Shape
    {
        private double height;
        private double width;
        public double Height
        {
            get {return height;}
            set { height = value;}
        }
        public double Width
        {
            get { return width; }
            set { width = value; }
        }
        public Rectangle(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }
        public override double CalculatePerimeter()
        {
            return 2*(height+width);
        }
        public override double CalculateArea()
        {
            return height*width;
        }
        public override string Draw()
        {
            return base.Draw()+"Rectangle";
        }
    }
}
