using DAL;
using DTO.FilmBoxDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class SeriesRepository : IFilmBox<SeriesCs>
    {
        FilmBox_DbEntities1 db = Db_Tools.DbInstance;
        public void Delete(int id)
        {
           Series gelen= db.Series.Find(id);
            db.Series.Remove(gelen);
            db.SaveChanges();
        }

        public List<SeriesCs> GetAll()
        {
            return db.Series.Select(c=> new SeriesCs {SeriesId=c.SeriesId,SeriesName=c.SeriesName,Views=c.Views,Vote=(int)c.Vote,SeriesDuration=c.SeriesDuration,DateOfConstruction=(DateTime)c.DateOfConstruction,Language=c.Language,SeriesEndorsement=(decimal)c.SeriesEndorsement,Status=c.Status , images=c.images}).ToList();
        }

        public SeriesCs GetByID(int ID)
        {
           Series gelen= db.Series.Find(ID);
            return new SeriesCs { SeriesId = gelen.SeriesId, SeriesName = gelen.SeriesName, Vote = (int)gelen.Vote, SeriesDuration = gelen.SeriesDuration, DateOfConstruction = (DateTime)gelen.DateOfConstruction, Language = gelen.Language, SeriesEndorsement = (decimal)gelen.SeriesEndorsement, Status = gelen.Status };
        }

        public void Insert(SeriesCs item)
        {
            db.Series.Add(new Series { SeriesName = item.SeriesName, Vote = item.Vote, SeriesDuration = item.SeriesDuration, DateOfConstruction = item.DateOfConstruction, Language = item.Language, SeriesEndorsement = item.SeriesEndorsement, Status = item.Status });
            db.SaveChanges();
        }

        public void Update(SeriesCs item)
        {
            Series gelen = db.Series.Find(item.SeriesId);
            gelen.SeriesName = item.SeriesName;
            gelen.Vote = item.Vote;
            gelen.SeriesDuration = item.SeriesDuration;
            gelen.DateOfConstruction = item.DateOfConstruction;
            gelen.Language = item.Language;
            gelen.SeriesEndorsement = item.SeriesEndorsement;
            gelen.Status = item.Status;
            db.SaveChanges();
        }
    }
}
