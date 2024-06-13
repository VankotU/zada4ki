using ProjectVegans.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectVegans.Controller
{
    public class TypeLogic
    {
        private VeganContext _vegansDbContext = new VeganContext();

        public List<VeganType> GetAllTypes()
        {
            return _vegansDbContext.VegansTypes.ToList();
        }

        public string GetTypeById(int id)
        {
            return _vegansDbContext.VegansTypes.Find(id).Name;
        }
    }
}
