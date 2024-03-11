using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ElectricDevice
{
    public class ICompare:Comparer<Laptop>
    {
        public override int Compare(Laptop x, Laptop y)
        {
            return x.Ram.CompareTo(y.Ram);
        }
    }
}
