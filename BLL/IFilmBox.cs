using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{

    
    public interface IFilmBox<T>
    {
        List<T> GetAll();
        T GetByID(int ID);
        void Insert(T item);
        void Update(T item);
        void Delete(int id);

    }
}
