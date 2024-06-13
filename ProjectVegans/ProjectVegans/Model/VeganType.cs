using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectVegans.Model
{
    public class VeganType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Vegans> Vegan { get; set; }
    }
}
