using PetShop.Data.Contexts;
using PetShop.Data.Repositories;
using PetShop.Data.Repositories.Interfaces;
using PetShop.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Service
{
    public class RepositoryFactory:IRepositoryFactory
    {
        public IAnimalRepository CreateAnimalRepo()
        {
            AnimalRepository animalRepo = new(new PetShopDataContext());
            return animalRepo;
        }

        public ICategoryRepository CreateCategoryRepo()
        {
            CategoryRepository categoryRepository = new(new PetShopDataContext());
            return categoryRepository;
        }

        public ICommentRepository CreateCommentRepo()
        {
            CommentRepository commentRepository = new(new PetShopDataContext());
            return commentRepository;
        }
    }
}
