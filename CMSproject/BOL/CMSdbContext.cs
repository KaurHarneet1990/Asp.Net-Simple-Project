using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BOL
{
    public class CMSdbContext : DbContext
    {
        public DbSet<tbl_Category> Category { get; set; }
        public DbSet<tbl_User> User { get; set; }
        public DbSet<tbl_Url> Url { get; set; }
    }
}
