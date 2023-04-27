using DAL;
using DTO.FilmBoxDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class FilmCustomerDetailRepository : IFilmBox<FilmCustomerDetailCs>
    {
        FilmBox_DbEntities1 db = Db_Tools.DbInstance;
        public void Delete(int id)
        {
            FilmCustomerDetail gelen= db.FilmCustomerDetail.Find(id);
            db.FilmCustomerDetail.Remove(gelen);
            db.SaveChanges();
        }

        public List<FilmCustomerDetailCs> GetAll()
        {
            return db.FilmCustomerDetail.Select(f=>new FilmCustomerDetailCs { FilmCustomerDetailID=f.FilmCustomerDetailID,FilmId=f.FilmId ,CustomerId=f.CustomerId } ).ToList();
        }

        public FilmCustomerDetailCs GetByID(int ID)
        {
            FilmCustomerDetail gelen = db.FilmCustomerDetail.Find(ID);
            return new FilmCustomerDetailCs { FilmCustomerDetailID=gelen.FilmCustomerDetailID, FilmId=gelen.FilmId,CustomerId=gelen.CustomerId};
            
        }

        public void Insert(FilmCustomerDetailCs item)
        {
            db.FilmCustomerDetail.Add(new FilmCustomerDetail { FilmId=item.FilmId,CustomerId=item.CustomerId}).ToString();
            db.SaveChanges();
        }

        public void Update(FilmCustomerDetailCs item)
        {
            FilmCustomerDetail gelen = db.FilmCustomerDetail.Find(item.FilmCustomerDetailID);
            gelen.FilmId = item.FilmId;
            gelen.CustomerId = item.CustomerId;
            db.SaveChanges();
        }
    }
}
