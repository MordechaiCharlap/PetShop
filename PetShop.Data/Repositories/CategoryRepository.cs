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
    public class CategoryRepository : ICategoryRepository
    {
        private readonly PetShopDataContext _context;
        public CategoryRepository(PetShopDataContext context)
        {
            _context = context;
        }
        public void Create(Category category)
        {
            _context.Add(category);
        }

        public void Delete(Category category)
        {
            _context.Remove(category);
        }

        public Category Get(int id)
        {
            return _context.Categories.First(category=>category.CategoryId==id);
        }

        public IEnumerable<Category> GetAll()
        {
            return _context.Categories;
        }

        public bool Update(Category category)
        {
            if (Get(category.CategoryId) != null)
            {
                _context.Categories.Update(category);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
