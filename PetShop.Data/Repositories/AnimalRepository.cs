using PetShop.Data.Contexts;
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
        private readonly PetShopDataContext _context;
        public AnimalRepository(PetShopDataContext context)
        {
            _context = context;
        }
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

        public IEnumerable<Animal> GetAll()
        {
            return _context.Animals;
        }

        public bool Update(in Animal entity)
        {
            throw new NotImplementedException();
        }
    }
}
