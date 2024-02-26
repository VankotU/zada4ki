using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalKingdom2
{
    public class Trainer
    {
        private IAnimal entity;
        public IAnimal Entity
        {
            get { return entity; }
            set { entity = value; }
        }
        public Trainer(IAnimal entity) 
        {
            this.entity = entity;
        }
        public void Make()
        {
            entity.Perform();
        }
    }
}
