using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace loginAndRegistration.Models
{
    public class ourDbContext:DbContext
    {
        public DbSet<userAccount> userAccount { get; set; }
    }
}