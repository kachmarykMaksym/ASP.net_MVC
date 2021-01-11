using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace lab6.Models
{
    public class Genre
    {
        [Key]
        public int GenreID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<MovieGenre> MovieGenres { get; set; }
    }
}