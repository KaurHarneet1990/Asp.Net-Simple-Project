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
        public DbSet<tbl_Category> TableCategory { get; set; }
        public DbSet<tbl_User> TableUser { get; set; }
        public DbSet<tbl_Url> TableUrl { get; set; }
    }
}
