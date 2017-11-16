using BOL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UrlBll
    {
        private UrlDb objDb;
        public UrlBll()
        {
            objDb = new UrlDb();
        }
        public IEnumerable<tbl_Url> GetAll()
        {
            return objDb.GetAll();
        }
        public tbl_Url GetByID(int id)
        {
            return objDb.GetByID(id);
        }
        public void Insert(tbl_Url url)
        {
             objDb.Insert(url);
        }
        public void Delete(int id)
        {
            objDb.Delete(id);
        }
        public void Update(tbl_Url url)
        {
            objDb.Update(url);
        }
       
    }
}
