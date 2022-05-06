﻿using PetShop.Data.Model;
using PetShop.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Service.Interfaces
{
    public interface IBusinessService
    {
        void DeleteAnimal(Animal animal);
        IEnumerable<Animal> GetTopThreeAnimals();
        IEnumerable<Animal> GetAnimalsByCategory(Category category);
    }
}
