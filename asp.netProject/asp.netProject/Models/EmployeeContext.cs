using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace asp.netProject.Models
{
    public class EmployeeContext:DbContext
    {
        public DbSet<Employee> abcd { get; set; }
    }
}