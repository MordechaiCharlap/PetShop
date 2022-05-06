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
    public class BusinessService : IBusinessService
    {

        private readonly IAnimalRepository _animalRepository;
        private readonly ICommentRepository _commentRepository;
        private readonly ICategoryRepository _categoryRepository;

        public BusinessService(IAnimalRepository animalRepository, ICommentRepository commentRepository, ICategoryRepository categoryRepository)
        {
            _animalRepository = animalRepository;
            _commentRepository = commentRepository;
            _categoryRepository = categoryRepository;
        }

        public void DeleteAnimal(Animal animal)
        {
            //Delete all the animal comments
            int animalId = animal.AnimalId;
            _commentRepository.GetAll()
                .Where(comment => comment.AnimalId == animalId)
                .ToList()
                .ForEach(comment => _commentRepository.Delete(comment));
            //Delete animal
            _animalRepository.Delete(animal);
        }

        public IEnumerable<Animal> GetAnimalsByCategory(Category category)
        {
            int categoryId = category.CategoryId;
            List<Animal> animalList = new List<Animal>();
            _animalRepository.GetAll()
                .Where(animal => animal.CategoryId == categoryId)
                .ToList()
                .ForEach(animal => animalList.Add(animal));
            return animalList;
        }

        public IEnumerable<Animal> GetTopThreeAnimals()
        {
            List<int> idList = new List<int>();
            _commentRepository
           .GetAll()
           .GroupBy(comment => comment.AnimalId)
           .Select(group => new { commentsGroup = group, totalComments = group.Count() })
           .Take(3)
           .OrderByDescending(row => row.totalComments)
           .ToList()
           .ForEach(row => idList.Add(row.commentsGroup.Key));

            List<Animal> animalList = new List<Animal>();
            _animalRepository
            .GetAll()
            .Where(animal => idList.Contains(animal.AnimalId))
            .ToList()
            .ForEach(animal => animalList.Add(animal));

            return animalList;
        }
    }
}
