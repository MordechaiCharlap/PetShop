using PetShop.Data.Model;
using PetShop.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Service
{
    public class CommentService : ICommentService
    {
        private readonly ICommentService _commentService;
        public CommentService(ICommentService commentService)
        {
            _commentService = commentService;
        }
        public bool CreateNewByAnimalId(string comment, int id)
        {
            throw new NotImplementedException();
        }

        public bool DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Comment> GetByAnimalId(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateById(int id, string comment)
        {
            throw new NotImplementedException();
        }
    }
}
