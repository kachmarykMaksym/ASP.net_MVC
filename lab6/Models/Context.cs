using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace lab6.Models
{
    public class Context : DbContext
    {
        public DbSet<Movie> Movie { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<VoiceActor> VoiceActor { get; set; }
        public DbSet<MovieGenre> MovieGenre { get; set; }
        public DbSet<MovieVoiceActor> MovieVoiceActor { get; set; }

        public class CinemaDBInitializer : DropCreateDatabaseAlways<Context>
        {
            protected override void Seed(Context context)
            {
                context.Movie.Add(new Movie { Name = "KonoSuba", Directed = "Ziri", Written = "Kori", Release = Convert.ToDateTime("05/22/2019"), Score = "8.5"});
                context.Movie.Add(new Movie { Name = "SwordArt", Directed = "Liza", Written = "Jiri", Release = Convert.ToDateTime("07/25/2018"), Score = "9.8" });
                context.Movie.Add(new Movie { Name = "YourName", Directed = "Makoto", Written = "Sinkai", Release = Convert.ToDateTime("05/13/2018"), Score = "9.0" });
                context.Movie.Add(new Movie { Name = "SilentVoice", Directed = "Kori", Written = "Sikoto", Release = Convert.ToDateTime("06/14/2017"), Score = "8.7" });
                context.Movie.Add(new Movie { Name = "TenkiNoKo", Directed = "Makoto", Written = "Sinkai", Release = Convert.ToDateTime("03/08/2020"), Score = "9.0" });

                context.Genre.Add(new Genre { Name = "Action"});
                context.Genre.Add(new Genre { Name = "School" });
                context.Genre.Add(new Genre { Name = "Romance" });
                context.Genre.Add(new Genre { Name = "Horror" });
                context.Genre.Add(new Genre { Name = "Fiction" });
                context.Genre.Add(new Genre { Name = "Comedy" });

                context.VoiceActor.Add(new VoiceActor { Name = "Say", Surname = "Con", Age = 32, Gender = "mal" });
                context.VoiceActor.Add(new VoiceActor { Name = "Hana", Surname = "Soto", Age = 27, Gender = "fem" });
                context.VoiceActor.Add(new VoiceActor { Name = "Lia", Surname = "Harayumi", Age = 18, Gender = "fem" });
                context.VoiceActor.Add(new VoiceActor { Name = "Asuka", Surname = "Sato", Age = 22, Gender = "fem" });
                context.VoiceActor.Add(new VoiceActor { Name = "Yato", Surname = "Nori", Age = 25, Gender = "mal" });

                context.MovieGenre.Add(new MovieGenre { MoviesID = 1, GenresID = 2});
                context.MovieGenre.Add(new MovieGenre { MoviesID = 1, GenresID = 4 });
                context.MovieGenre.Add(new MovieGenre { MoviesID = 1, GenresID = 5 });
                context.MovieGenre.Add(new MovieGenre { MoviesID = 2, GenresID = 1 });
                context.MovieGenre.Add(new MovieGenre { MoviesID = 2, GenresID = 2 });
                context.MovieGenre.Add(new MovieGenre { MoviesID = 4, GenresID = 3 });
                context.MovieGenre.Add(new MovieGenre { MoviesID = 4, GenresID = 4 });
                context.MovieGenre.Add(new MovieGenre { MoviesID = 5, GenresID = 1 });

                context.MovieVoiceActor.Add(new MovieVoiceActor { MoviesID = 1, VoiceActorsID = 1 });
                context.MovieVoiceActor.Add(new MovieVoiceActor { MoviesID = 1, VoiceActorsID = 3 });
                context.MovieVoiceActor.Add(new MovieVoiceActor { MoviesID = 1, VoiceActorsID = 4 });
                context.MovieVoiceActor.Add(new MovieVoiceActor { MoviesID = 2, VoiceActorsID = 5 });
                context.MovieVoiceActor.Add(new MovieVoiceActor { MoviesID = 3, VoiceActorsID = 1 });
                context.MovieVoiceActor.Add(new MovieVoiceActor { MoviesID = 4, VoiceActorsID = 2 });
                context.MovieVoiceActor.Add(new MovieVoiceActor { MoviesID = 4, VoiceActorsID = 4 });
                context.MovieVoiceActor.Add(new MovieVoiceActor { MoviesID = 5, VoiceActorsID = 3 });

                base.Seed(context);
            }
        }
    }
}