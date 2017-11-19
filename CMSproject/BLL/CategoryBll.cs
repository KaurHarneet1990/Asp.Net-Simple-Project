using BOL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CategoryBll
    {
        private CategoryDb objDb;
        public CategoryBll()
        {
            objDb = new CategoryDb();
        }
        public IEnumerable<tbl_Category> GetAll()
        {
            return objDb.GetAll();
        }
        public tbl_Category GetByID(int id)
        {
            return objDb.GetByID(id);
        }
        public void Insert(tbl_Category category)
        {
            objDb.Insert(category);
        }
        public void Delete(int id)
        {
            objDb.Delete(id);
        }
        public void Update(tbl_Category category)
        {
            objDb.Update(category);
        }
    }
}
