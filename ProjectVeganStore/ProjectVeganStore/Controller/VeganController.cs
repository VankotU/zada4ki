using ProjectVeganStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectVeganStore.Controller
{
    public class VeganController
    {
        private VegansShopDbContext _vegansDbContext= new VegansShopDbContext();
        public Vegans Get(int id)
        {
            Vegans findedVegans = _vegansDbContext.Vegans.Find(id);
            if (findedVegans != null) 
            {
                _vegansDbContext.Entry(findedVegans).Reference(x => x.Types).Load();
            }
            return findedVegans;
        }
        public List<Vegans> GetAll()
        {
            return _vegansDbContext.Vegans.Include("VeganType").ToList();
        }
        public void Create(Vegans vegans)
        {
            _vegansDbContext.Vegans.Add(vegans);
            _vegansDbContext.SaveChanges();
        }
        public void Update(int id, Vegans vegans)
        {
            Vegans findedVegans = _vegansDbContext.Vegans.Find(id);
            if (findedVegans==null)
            {
                return;
            }
        }
        public void Delete(int id) 
        {
            Vegans findedVegans = _vegansDbContext.Vegans.Find(id);
            _vegansDbContext.Vegans.Remove(findedVegans);
            _vegansDbContext.SaveChanges();
        }
    }
}
