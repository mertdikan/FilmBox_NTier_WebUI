
using DAL;
using DTO.FilmBoxDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class ActorRepository : IFilmBox<Actorcs>
    {
        FilmBox_DbEntities1 db = Db_Tools.DbInstance;

        public void Delete(int id)
        {
            Actor gelen = db.Actor.Find(id);
            db.Actor.Remove(gelen);
            db.SaveChanges();
        }

        public List<Actorcs> GetAll()
        {
            return db.Actor.Select(c => new Actorcs { ActorId = c.ActorId, FirstName = c.FirstName, LastName = c.LastName, Age = (int)c.Age, Awards = (int)c.Awards, Gender = c.Gender ,images= c.images}).ToList();
        }

        public Actorcs GetByID(int ID)
        {
            Actor act = db.Actor.Find(ID);
            return new Actorcs { ActorId = act.ActorId, FirstName = act.FirstName, LastName = act.LastName, Age = (int)act.Age, Awards = (int)act.Awards, Gender = act.Gender };
        }

        public void Insert(Actorcs item)
        {
            db.Actor.Add(new Actor { ActorId = item.ActorId, FirstName = item.FirstName, LastName = item.LastName, Age = (int)item.Age, Awards = (int)item.Awards, Gender = item.Gender });
            db.SaveChanges();
        }

        public void Update(Actorcs item)
        {
            Actor gelen = db.Actor.Find(item.ActorId);
            gelen.FirstName = item.FirstName;
            gelen.LastName = item.LastName;
            gelen.Age = (int)item.Age;
            gelen.Awards = (int)item.Awards;
            gelen.Gender = item.Gender;
            db.SaveChanges();


        }
    }
}

