using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class TablolarRepository
    {
        
        FilmBox_DbEntities1 db = Db_Tools.DbInstance;
        public string GetAll()
        {
            return db.Set<Db_Tools>().ToString();
            
            
        }
    }
}
