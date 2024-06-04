using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectVeganStore.Model
{
    public class Vegans
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Vegan_type_Id { get; set; }
        public string Type_Name { get; set; }
        public VeganType Types { get; set; }
    }
}
