﻿using PetShop.Data.Contexts;
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
        public void Create(Animal animal)
        {
            _context.Add(animal);
            _context.SaveChanges();
        }

        public void Delete(Animal animal)
        {
            _context.Remove(animal);
            _context.SaveChanges();
        }

        public Animal Get(int id)
        {
            return _context.Animals.First(animal => animal.AnimalId == id);
        }

        public IEnumerable<Animal> GetAll()
        {
            List<Animal> animalList = new List<Animal>();
            _context.Animals.ToList().ForEach(animal => animalList.Add(animal));
            return animalList;
        }

        public bool Update(Animal newAnimal)
        {
            if (Get(newAnimal.AnimalId) != null)
            {
                _context.Animals.Update(newAnimal);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
