using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoProject.Models
{
    public class Register
    {
        
       [Key]
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }


    }
}