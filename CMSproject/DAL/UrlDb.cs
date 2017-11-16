using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;
using System.Data.Entity;

namespace DAL
{
   public class UrlDb
    {
        private CMSdbContext db;
        public UrlDb()
        {
            db = new CMSdbContext();
        }
        public IEnumerable<tbl_Url> GetAll()
        {
            return db.TableUrl.ToList();
        }
       public tbl_Url GetByID(int id)
        {
            return db.TableUrl.Find(id);
        }
       public  void Insert(tbl_Url url)
        {
            db.TableUrl.Add(url);
            Save();
        }
        public void Delete(int id)
        {
            tbl_Url url = db.TableUrl.Find(id);
            db.TableUrl.Remove(url);
            Save();
        }
        public void Update(tbl_Url url)
        {
            db.Entry(url).State = EntityState.Modified;
        }
        public void Save()
        {
            db.SaveChanges();
        }

    }
}
