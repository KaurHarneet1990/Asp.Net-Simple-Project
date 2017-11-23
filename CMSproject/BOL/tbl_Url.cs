using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public partial class tbl_Url
    {
        [Key]
        public int UrlId { get; set; }
        [Required]
        public string UrlITitle{ get; set; }
        [Required]
        [Url]
        public string Url { get; set; }
        [Required]
        public string UrlDesc { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public Nullable<int> UserId { get; set; }
        public string IsApproved { get; set; }
        public virtual tbl_Category tbl_Category { get; set; }
        public virtual tbl_User tbl_User { get; set; }
    }
}
