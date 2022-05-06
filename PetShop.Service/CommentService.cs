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
    public class CommentService : ICommentService
    {
        private readonly ICommentRepository _commentRepository;
        public CommentService(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public IEnumerable<Comment> GetByAnimalId(int id)
        {
            return _commentRepository.GetAll()
                .Where(comment => comment.AnimalId == id);
        }
        public void Create(Comment comment)
        {
            _commentRepository.Create(comment);
        }
        public Comment Get(int id)
        {
            return _commentRepository.Get(id);
        }
        public bool Update(Comment comment)
        {
            if (_commentRepository.Update(comment)) return true;
            return false;
        }
        public void Delete(Comment comment)
        {
            _commentRepository.Delete(comment);
        }
        public IEnumerable<Comment> GetAll()
        {
            return _commentRepository.GetAll();
        }


        

    }
}
