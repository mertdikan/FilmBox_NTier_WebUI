using DAL;
using DTO.FilmBoxDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class FilmRepository : IFilmBox<FilmCs>
    {
        FilmBox_DbEntities1 db = Db_Tools.DbInstance;
        public void Delete(int id)
        {
            Film gelen = db.Film.Find(id);
            db.Film.Remove(gelen);
            db.SaveChanges();
        }

        public List<FilmCs> GetAll()
        {
            return db.Film.Select(c => new FilmCs { FilmId = c.FilmId, FilmName = c.FilmName, Views = c.Views, Vote = (int)c.Vote, FilmDuration = c.FilmDuration, DateOfConstruction = (DateTime)c.DateOfConstruction, Language = c.Language, FilmEndorsement = (decimal)c.FilmEndorsement, Status = c.Status ,images=c.images }).ToList();
        }

        public FilmCs GetByID(int ID)
        {
            Film gelen = db.Film.Find(ID);
            return new FilmCs { FilmId = gelen.FilmId, FilmName = gelen.FilmName, Views = gelen.Views, Vote = (int)gelen.Vote, FilmDuration = gelen.FilmDuration, DateOfConstruction = (DateTime)gelen.DateOfConstruction, Language = gelen.Language, FilmEndorsement = (decimal)gelen.FilmEndorsement, Status = gelen.Status };
        }

        public void Insert(FilmCs item)
        {
            db.Film.Add(new Film { FilmName = item.FilmName, Views = item.Views, Vote = (int)item.Vote, FilmDuration = item.FilmDuration, DateOfConstruction = (DateTime)item.DateOfConstruction, Language = item.Language, FilmEndorsement = (decimal)item.FilmEndorsement, Status = item.Status });
            db.SaveChanges();
        }

        public void Update(FilmCs item)
        {
            Film gelen = db.Film.Find(item.FilmId);
            gelen.FilmName = item.FilmName;
            gelen.Views = item.Views;
            gelen.Vote = (int)item.Vote;
            gelen.FilmDuration = item.FilmDuration;
            gelen.DateOfConstruction = (DateTime)item.DateOfConstruction;
            gelen.Language = item.Language;
            gelen.FilmEndorsement = (decimal)item.FilmEndorsement;
            gelen.Status = item.Status;

            db.SaveChanges();
        }
    }
}
