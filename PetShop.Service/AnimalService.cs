using PetShop.Data.Model;
using PetShop.Data.Repositories.Interfaces;
using PetShop.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Service
{
    public class AnimalService : IAnimalService
    {
        private readonly IAnimalRepository _animalRepository;
        public AnimalService(IAnimalRepository animalRepository)
        {
            _animalRepository = animalRepository;
        }
        public bool Create(Animal animal)
        {
            if(_animalRepository.Create(animal)) return true;
            return false;
        }

        public bool DeleteById(int id)
        {
            if (_animalRepository.Delete(GetById(id))) return true;
            else return false;
        }

        public bool EditDetails(Animal animal)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Animal> GetAll()
        {
            throw new NotImplementedException();
        }

        public Animal GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Animal> SearchByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
