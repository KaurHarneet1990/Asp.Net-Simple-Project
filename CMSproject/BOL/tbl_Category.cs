using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
   public class tbl_Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDesc { get; set; }
        public virtual ICollection<tbl_Url> tbl_Url { get; set; }
    }
}
