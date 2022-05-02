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
        public bool CreateNewCommentByAnimalId(string comment, int id)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCommentByAnimalId(int id)
        {
            throw new NotImplementedException();
        }

        public string GetCommentByAnimalIdAndCommentId(int animalId, int commentId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Comment> GetCommentsByAnimalId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Comment> GetCommentsByAnimalName(string name)
        {
            throw new NotImplementedException();
        }

        public bool UpdateCommentByAnimalId(int id, string comment)
        {
            throw new NotImplementedException();
        }
    }
}
