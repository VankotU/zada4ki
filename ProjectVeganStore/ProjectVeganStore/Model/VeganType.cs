using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectVeganStore.Model
{
    public class VeganType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Vegans> Vegans { get; set; }
    }
}
