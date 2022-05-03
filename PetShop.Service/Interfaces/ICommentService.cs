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
        IEnumerable<Comment> GetByAnimalId(int id);
        bool CreateNewByAnimalId(string comment, int id);
        bool DeleteById(int id);
        bool UpdateById(int id, string comment);
    }
}
