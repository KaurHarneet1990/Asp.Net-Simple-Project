using BOL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class UserDb
    {
        private CMSdbContext db;
        public UserDb()
        {
            db = new CMSdbContext();
        }
        public IEnumerable<tbl_User> GetAll()
        {
            return db.TableUser.ToList();
        }
        public tbl_User GetByID(int id)
        {
            return db.TableUser.Find(id);
        }
        public void Insert(tbl_User User)
        {
            db.TableUser.Add(User);
            Save();
        }
        public void Delete(int id)
        {
            tbl_User user = db.TableUser.Find(id);
            db.TableUser.Remove(user);
            Save();
        }
        public void Update(tbl_User user)
        {
            db.Entry(user).State = EntityState.Modified;
        }
        public void Save()
        {
            db.SaveChanges();
        }
    }
}
