using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectVegans.Model
{
    public class VeganContext:DbContext
    {
        public VeganContext() : base("VeganContext")
        {

        }
        public DbSet<Vegans> Vegan { get; set; }
        public DbSet<VeganType> VegansTypes { get; set; }
    }
}
