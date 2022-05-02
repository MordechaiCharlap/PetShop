using PetShop.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Service.Interfaces
{
    public interface ICommentService
    {
        IEnumerable<Comment> GetCommentsByAnimalName(string name);
        IEnumerable<Comment> GetCommentsByAnimalId(int id);
        bool CreateNewCommentByAnimalId(string comment, int id);
        bool DeleteCommentByAnimalId(int id);
        bool UpdateCommentByAnimalId(int id, string comment);
        string GetCommentByAnimalIdAndCommentId(int animalId, int commentId);
    }
}
