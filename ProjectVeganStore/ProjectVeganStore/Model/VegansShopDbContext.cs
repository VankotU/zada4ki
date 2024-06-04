using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectVeganStore.Model
{
    public class VegansShopDbContext:DbContext
    {
        public VegansShopDbContext():base("VegansShopDbContext")
        {

        }
        public DbSet<Vegans> Vegans { get; set; }
        public DbSet<VeganType> VegansTypes { get; set; }    
    }
}
