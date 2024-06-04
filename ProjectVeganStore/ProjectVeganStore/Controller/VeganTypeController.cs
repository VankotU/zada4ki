using ProjectVeganStore.Model;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectVeganStore.Controller
{
    public class VeganTypeController
    {
        private VegansShopDbContext _vegansDbContext = new VegansShopDbContext();

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
