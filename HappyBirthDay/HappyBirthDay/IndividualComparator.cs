using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyBirthDay
{
    public class IndividualComparator:IComparer<Individuals>
    {
        public int Compare(Individuals x, Individuals y)
        {
            int result = x.Id.CompareTo(y.Id);
            return result;
        }
    }
}
