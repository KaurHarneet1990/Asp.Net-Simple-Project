using BOL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserBll
    {
        private UserDb objDb;
        public UserBll()
        {
            objDb = new UserDb();
        }
        public IEnumerable<tbl_User> GetAll()
        {
            return objDb.GetAll();
        }
        public tbl_User GetByID(int id)
        {
            return objDb.GetByID(id);
        }
        public void Insert(tbl_User user)
        {
            objDb.Insert(user);
        }
        public void Delete(int id)
        {
            objDb.Delete(id);
        }
        public void Update(tbl_User user)
        {
            objDb.Update(user);
        }
    }
}
