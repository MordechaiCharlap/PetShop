using PetShop.Data.Model;
using PetShop.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Data.Repositories
{
    public class AnimalRepository : IAnimalRepository
    {
        public bool Create(in Animal entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(in Animal entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Animal> Get(string name)
        {
            throw new NotImplementedException();
        }

        public Animal Get(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Animal> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Save(in Animal entity)
        {
            throw new NotImplementedException();
        }

    }
}
