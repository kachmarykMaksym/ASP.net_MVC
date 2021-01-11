using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lab6.Models
{
    public class MovieVoiceActor
    {
        [Key]
        public int MovieVoiceActorID { get; set; }
        public virtual Movie Movies { get; set; }
        public virtual VoiceActor VoiceActors { get; set; }
        public int MoviesID { get; set; }
        public int VoiceActorsID { get; set; }
    }
}