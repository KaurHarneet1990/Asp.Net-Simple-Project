using BOL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CategoryDb
    {
        private CMSdbContext db;
        public CategoryDb()
        {
            db = new CMSdbContext();
        }
        public IEnumerable<tbl_Category> GetAll()
        {
            return db.TableCategory.ToList();
        }
        public tbl_Category GetByID(int id)
        {
            return db.TableCategory.Find(id);
        }
        public void Insert(tbl_Category category)
        {
            db.TableCategory.Add(category);
            Save();
        }
        public void Delete(int id)
        {
            tbl_Category category = db.TableCategory.Find(id);
            db.TableCategory.Remove(category);
            Save();
        }
        public void Update(tbl_Category category)
        {
            db.Entry(category).State = EntityState.Modified;
        }
        public void Save()
        {
            db.SaveChanges();
        }
    }
}
