using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace lab6.Models
{
    public class VoiceActor
    {
        [Key]
        public int VoiceActorID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public virtual ICollection<MovieVoiceActor> MovieActors { get; set; }
    }
}