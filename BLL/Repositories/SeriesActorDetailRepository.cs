using DAL;
using DTO.FilmBoxDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class SeriesActorDetailRepository : IFilmBox<SeriesActorDetailCs>
    {
        FilmBox_DbEntities1 db = Db_Tools.DbInstance;
        public void Delete(int id)
        {
           SeriesActorDetail gelen= db.SeriesActorDetail.Find(id);
            db.SeriesActorDetail.Remove(gelen);
            db.SaveChanges();
        }

        public List<SeriesActorDetailCs> GetAll()
        {
            return db.SeriesActorDetail.Select(c => new SeriesActorDetailCs { SeriesActorDetailID = c.SeriesActorDetailID, SeriesId = c.SeriesId, ActorId = c.ActorId, Role = c.Role, ActorRate = (int)c.ActorRate }).ToList();
        }

        public SeriesActorDetailCs GetByID(int ID)
        {
           SeriesActorDetail gelen= db.SeriesActorDetail.Find(ID);
            return new SeriesActorDetailCs { SeriesActorDetailID = gelen.SeriesActorDetailID, SeriesId = gelen.SeriesId, ActorId = gelen.ActorId, Role = gelen.Role, ActorRate = (int)gelen.ActorRate };
        }

        public void Insert(SeriesActorDetailCs item)
        {
            db.SeriesActorDetail.Add(new SeriesActorDetail { SeriesActorDetailID = item.SeriesActorDetailID, SeriesId = item.SeriesId, ActorId = item.ActorId, Role = item.Role, ActorRate = (int)item.ActorRate});
            db.SaveChanges();
        }

        public void Update(SeriesActorDetailCs item)
        {
            SeriesActorDetail gelen = db.SeriesActorDetail.Find(item.SeriesActorDetailID);
            gelen.SeriesId = item.SeriesId;
            gelen.ActorId = item.ActorId;
            gelen.Role = item.Role;
            gelen.ActorRate = item.ActorRate;
            db.SaveChanges();
        }
    }
}
