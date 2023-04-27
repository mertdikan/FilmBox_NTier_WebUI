using DAL;
using DTO.FilmBoxDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class FilmCategortDetailRepository : IFilmBox<FilmCategoryDetailCs>
    {
        FilmBox_DbEntities1 db = Db_Tools.DbInstance;
        public void Delete(int id)
        {
            FilmCategoryDetail gelen = db.FilmCategoryDetail.Find(id);
            db.FilmCategoryDetail.Remove(gelen);
            db.SaveChanges();

        }

        public List<FilmCategoryDetailCs> GetAll()
        {
            return db.FilmCategoryDetail.Select(c => new FilmCategoryDetailCs {FilmCategoryDetailID=c.FilmCategoryDetailID,FilmId=c.FilmId,CategoryId=c.CategoryId }).ToList();
        }

        public FilmCategoryDetailCs GetByID(int ID)
        {
            FilmCategoryDetail gelen= db.FilmCategoryDetail.Find(ID);
            return new FilmCategoryDetailCs { FilmCategoryDetailID = gelen.FilmCategoryDetailID, FilmId = gelen.FilmId, CategoryId = gelen.CategoryId };
        }

        public void Insert(FilmCategoryDetailCs item)
        {
            db.FilmCategoryDetail.Add(new FilmCategoryDetail { FilmId = item.FilmId, CategoryId = item.CategoryId });
            db.SaveChanges();
        }

        public void Update(FilmCategoryDetailCs item)
        {
            FilmCategoryDetail gelen = db.FilmCategoryDetail.Find(item.FilmCategoryDetailID);
            gelen.FilmId = item.FilmId;
            gelen.CategoryId = item.CategoryId;
            db.SaveChanges();

        }
    }
}
