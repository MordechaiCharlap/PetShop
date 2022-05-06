using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Service.Interfaces
{
    public interface ICRUDService<T> where T : class
    {
        void Create(T entity);
        T Get(int id);
        bool Update(T entity);
        void Delete(T entity);
        IEnumerable<T> GetAll();

    }
}
