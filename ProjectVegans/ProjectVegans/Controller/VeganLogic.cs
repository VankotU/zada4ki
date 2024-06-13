using ProjectVegans.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectVegans.Controller
{
    public class VeganLogic
    {
        private VeganContext _vegansDbContext = new VeganContext();
        public Vegans Get(int id)
        {
            Vegans findedVegans = _vegansDbContext.Vegan.Find(id);
            if (findedVegans != null)
            {
                _vegansDbContext.Entry(findedVegans).Reference(x => x.Types).Load();
            }
            return findedVegans;
        }
        public List<Vegans> GetAll()
        {
            return _vegansDbContext.Vegan.Include("Types").ToList();
        }
        public void Create(Vegans vegans)
        {
            _vegansDbContext.Vegan.Add(vegans);
            _vegansDbContext.SaveChanges();
        }
        public void Update(int id, Vegans vegans)
        {
            Vegans findedVegans = _vegansDbContext.Vegan.Find(id);
            if (findedVegans == null)
            {
                return;
            }
            findedVegans.Name = vegans.Name;
            findedVegans.Price = vegans.Price;
            findedVegans.Description = vegans.Description;
            findedVegans.VeganTypeId = vegans.VeganTypeId;
            _vegansDbContext.SaveChanges();
        }
        public void Delete(int id)
        {
            Vegans findedVegans = _vegansDbContext.Vegan.Find(id);
            _vegansDbContext.Vegan.Remove(findedVegans);
            _vegansDbContext.SaveChanges();
        }
    }
}
