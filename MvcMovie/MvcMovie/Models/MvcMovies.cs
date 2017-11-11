using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcMovie.Models
{
    public class MvcMovies
    {
        public int ID { get; set; }
        public string Title { get; set; }
     
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public Decimal Price { get; set; }
    }

    public class MovieDbContext : DbContext
    {
        public DbSet<MvcMovies> Movies { get; set; }
    }
}