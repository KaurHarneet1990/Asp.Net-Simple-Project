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
        public class UniqueUrlAttribute : ValidationAttribute
        {
            protected override ValidationResult IsValid(object value, ValidationContext validationContext)
            {
                CMSdbContext db = new CMSdbContext();
                string urlValue = value.ToString();
                int count = db.TableUrl.Where(x => x.Url == urlValue).ToList().Count();
                if (count != 0)
                    return new ValidationResult("Url Already Exits.");
                return ValidationResult.Success;
            }
        }

        [Key]
        public int UrlId { get; set; }
        [Required]
        public string UrlITitle{ get; set; }
        [Required]
        [Url]
        [UniqueUrl]
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
