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
        public Comment Delete(in Comment entity)
        {
            throw new NotImplementedException();
        }

        public Comment Get(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Comment> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Comment> GetByAnimalId(int id)
        {
            throw new NotImplementedException();
        }

        public Comment Save(Comment entity)
        {
            throw new NotImplementedException();
        }
    }
}
