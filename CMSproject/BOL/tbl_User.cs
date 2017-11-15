using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public class tbl_User
    {
        [Key]
        public int UserId { get; set; }
        public string UserEmail { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public virtual ICollection<tbl_Url> tbl_Url { get; set; }

    }
}
