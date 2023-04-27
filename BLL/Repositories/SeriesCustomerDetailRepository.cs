using DAL;
using DTO.FilmBoxDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class SeriesCustomerDetailRepository : IFilmBox<SeriesCustomerDetailCs>
    {
        FilmBox_DbEntities1 db = Db_Tools.DbInstance;
        public void Delete(int id)
        {
            SeriesCustomerDetail gelen= db.SeriesCustomerDetail.Find(id);
            db.SeriesCustomerDetail.Remove(gelen);
            db.SaveChanges();
        }

        public List<SeriesCustomerDetailCs> GetAll()
        {
            return db.SeriesCustomerDetail.Select(c=> new SeriesCustomerDetailCs { SeriesCustomerDetailID = c.SeriesCustomerDetailID,SeriesId = c.SeriesId,CustomerId=c.CustomerId }).ToList();
        }

        public SeriesCustomerDetailCs GetByID(int ID)
        {
           SeriesCustomerDetail gelen= db.SeriesCustomerDetail.Find(ID);
            return new SeriesCustomerDetailCs { SeriesCustomerDetailID = gelen.SeriesCustomerDetailID, SeriesId = gelen.SeriesId, CustomerId = gelen.CustomerId };
        }

        public void Insert(SeriesCustomerDetailCs item)
        {
            db.SeriesCustomerDetail.Add(new SeriesCustomerDetail { SeriesId = item.SeriesId, CustomerId = item.CustomerId });
            db.SaveChanges();
        }

        public void Update(SeriesCustomerDetailCs item)
        {
            SeriesCustomerDetail gelen= db.SeriesCustomerDetail.Find(item.SeriesCustomerDetailID);
            gelen.SeriesId = item.SeriesId;
            gelen.CustomerId = item.CustomerId;
            db.SaveChanges();
        }
    }
}
