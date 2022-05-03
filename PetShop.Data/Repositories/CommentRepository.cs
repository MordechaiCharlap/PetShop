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
    public class CommentRepository : ICommentRepository
    {
        private readonly PetShopDataContext _context;
        public CommentRepository(PetShopDataContext context)
        {
            _context=context;
        }
        public bool Create(in Comment entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(in Comment entity)
        {
            throw new NotImplementedException();
        }

        public Comment Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Comment> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Comment> GetByAnimalId(int id)
        {
            return _context.Comments.Where(c => c.AnimalId == id);
        }

        public bool Update(in Comment entity)
        {
            throw new NotImplementedException();
        }
    }
}
