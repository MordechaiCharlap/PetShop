using PetShop.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Service.Interfaces
{
    public interface IAnimalService
    {
        Animal GetAnimalById(int id);
        IEnumerable<Animal> GetAnimalsByName(string name);
        bool CreateAnimal(Animal animal);
        bool DeleteAnimalById(int id);
        bool EditAnimalDetails(Animal animal);
        bool AddNewAnimal(Animal animal);
        IEnumerable<Animal> GetAllAnimals();
        IEnumerable<Animal> GetAllAnimalsByPopularity();
    }
}
