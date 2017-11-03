using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DemoProject.Models
{
    public class RegContext : DbContext
    {
        public DbSet<Register> register { get; set; }
    }
}