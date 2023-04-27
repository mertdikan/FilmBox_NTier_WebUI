using DAL;
using DTO.FilmBoxDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class CustomerRepository : IFilmBox<CustomerCs>
    {
        FilmBox_DbEntities1 db = Db_Tools.DbInstance;
        public void Delete(int id)
        {
            Customer gelen= db.Customer.Find(id);
            db.Customer.Remove(gelen);
            db.SaveChanges();
        }

        public List<CustomerCs> GetAll()
        {
            return db.Customer.Select(c => new CustomerCs { FirstName = c.FirstName, LastName = c.LastName, IdentityNo = c.IdentityNo, Gender = c.Gender, Age = (int)c.Age, PhoneNumer = c.PhoneNumer, Email = c.Email }).ToList();

        }

        public CustomerCs GetByID(int ID)
        {
            Customer gelen = db.Customer.Find(ID);
            return new CustomerCs { FirstName = gelen.FirstName, LastName = gelen.LastName, IdentityNo = gelen.IdentityNo, Gender = gelen.Gender, Age = (int)gelen.Age, PhoneNumer = gelen.PhoneNumer, Email = gelen.Email };
        }

        public void Insert(CustomerCs item)
        {
            db.Customer.Add(new Customer { FirstName = item.FirstName, LastName = item.LastName, IdentityNo = item.IdentityNo, Gender = item.Gender, Age = (int)item.Age, PhoneNumer = item.PhoneNumer, Email = item.Email });
            db.SaveChanges();
        }

        public void Update(CustomerCs item)
        {
            Customer gelen = db.Customer.Find(item.CustomerId);
            gelen.FirstName = item.FirstName;
            gelen.LastName = item.LastName;
            gelen.IdentityNo = item.IdentityNo;
            gelen.Gender = item.Gender; gelen.Age = (int)item.Age;
            gelen.PhoneNumer = item.PhoneNumer;
            gelen.Email = item.Email;
            db.SaveChanges();


        }
    }
}
