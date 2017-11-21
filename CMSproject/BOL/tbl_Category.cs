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
        //public tbl_Category()
        //{
        //    this.tbl_Url = new HashSet<tbl_Url>();
        //}
        [Key]
        public int CategoryId { get; set; }
        [Required]
        [Display (Name="Category Name")]
        public string CategoryName { get; set; }
        [Display(Name = "Category Description")]
        public string CategoryDesc { get; set; }
        public virtual ICollection<tbl_Url> tbl_Url { get; set; }
    }
}
