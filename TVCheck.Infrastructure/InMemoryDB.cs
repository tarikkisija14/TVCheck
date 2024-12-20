using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TVCheck.Data;

namespace TVCheck.Infrastructure
{
    public  class InMemoryDB
    {
        public static List<User> Users { get; set; } = User.GenerateUsers();
        public static List<StreamingService> StreamingServices { get; set; } = StreamingService.GenerateStreamingServices();

        public static List<Show> Shows { get; set; } = Show.GenerateShows();

        public static List<Actor> Actors { get; set; } = Actor.GenerateActors();
        public static List<Genre> Genres { get; set; } = Genre.GenerateGenres();

        public static List<Anime> Animes { get; set; } = Anime.GenerateAnime();

    
    }
}
