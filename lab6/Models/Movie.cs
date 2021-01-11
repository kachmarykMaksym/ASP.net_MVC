using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace lab6.Models
{
    public class Movie
    {
        [Key]
        public int MovieID { get; set; }
        public string Name { get; set; }
        public string Directed { get; set; }
        public string Written { get; set; }
        public DateTime Release { get; set; }
        public string Score { get; set; }

        public virtual ICollection<MovieGenre> MovieGenres { get; set; }
        public virtual ICollection<MovieVoiceActor> MovieActors { get; set; }
    }
}