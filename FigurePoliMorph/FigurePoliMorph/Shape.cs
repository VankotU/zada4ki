using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurePoliMorph
{
    public abstract class Shape:IDraw
    {
        public abstract double CalculatePerimeter();
        public abstract double CalculateArea();
        public virtual string Draw() => "Drawing";
    }
}
