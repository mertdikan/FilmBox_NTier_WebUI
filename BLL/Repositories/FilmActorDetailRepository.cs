using DAL;
using DTO.FilmBoxDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class FilmActorDetailRepository : IFilmBox<FilmActorDetailCs>
    {
        FilmBox_DbEntities1 db = Db_Tools.DbInstance;
        public void Delete(int id)
        {
            FilmActorDetail gelen= db.FilmActorDetail.Find(id);
            db.FilmActorDetail.Remove(gelen);
            db.SaveChanges();
        }

        public List<FilmActorDetailCs> GetAll()
        {
            return db.FilmActorDetail.Select(c => new FilmActorDetailCs {FilmActorDetailID=c.FilmActorDetailID,FilmId=c.FilmId,ActorId=c.ActorId,Role=c.Role,ActorRate=(int)c.ActorRate }).ToList();
        }

        public FilmActorDetailCs GetByID(int ID)
        {
            FilmActorDetail gelen= db.FilmActorDetail.Find(ID);
            return new FilmActorDetailCs { FilmActorDetailID = gelen.FilmActorDetailID, FilmId = gelen.FilmId, ActorId = gelen.ActorId, Role = gelen.Role, ActorRate = (int)gelen.ActorRate };
        }

        public void Insert(FilmActorDetailCs item)
        {
            db.FilmActorDetail.Add(new FilmActorDetail { FilmId = item.FilmId, ActorId = item.ActorId, Role = item.Role, ActorRate = (int)item.ActorRate });
            db.SaveChanges();
        }

        public void Update(FilmActorDetailCs item)
        {
            FilmActorDetail gelen = db.FilmActorDetail.Find(item.FilmActorDetailID);
            gelen.FilmId = item.FilmId;
            gelen.ActorId = item.ActorId;
            gelen.Role = item.Role;
            gelen.ActorRate = item.ActorRate;
            db.SaveChanges();
        }
    }
}
