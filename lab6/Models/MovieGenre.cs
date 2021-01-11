using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lab6.Models
{
    public class MovieGenre
    {
        [Key]
        public int MovieGenreID { get; set; }
        public virtual Movie Movies { get; set; }
        public virtual Genre Genres { get; set; }
        public int MoviesID { get; set; }
        public int GenresID { get; set; }

    }
}