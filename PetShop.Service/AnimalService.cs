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
        private readonly IAnimalRepository animalRepository;
        public AnimalService(IAnimalRepository animalRepository)
        {
            this.animalRepository = animalRepository;
        }
        public bool AddNewAnimal(Animal animal)
        {
            if(animalRepository.Save(animal)) return true;
            return false;
        }

        public bool CreateAnimal(Animal animal)
        {
            if(animalRepository.Create(animal)) return true;
            return false;
        }

        public bool DeleteAnimalById(int id)
        {
            if (animalRepository.Delete(GetAnimalById(id))) return true;
            else return false;
        }

        public bool EditAnimalDetails(Animal animal)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Animal> GetAllAnimals()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Animal> GetAllAnimalsByPopularity()
        {
            throw new NotImplementedException();
        }

        public Animal GetAnimalById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Animal> GetAnimalsByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
