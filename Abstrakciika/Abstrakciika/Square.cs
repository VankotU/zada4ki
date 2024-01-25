using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrakciika
{
    public class Square:Figura
    {
        public Square(double size1):base(size1) 
        {

        }

        public override double Area()
        {
             return size1 * size1;
        }

        public override void InfoFigura()
        {
            base.InfoFigura();
        }
    }
}
