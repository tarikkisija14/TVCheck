using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVCheck.Data
{
    public class Anime
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime RelaseDate { get; set; }

        public string Descripton {  get; set; }

        List<Genre>Genres { get; set; }=new List<Genre>();

        public int SeasonCount {  get; set; }

        public bool IsCompleted { get; set; }

        public double AverageRating { get; set; }
        public TimeSpan TotalDuration { get; set; }
        public List<Episode> Episodes { get; set; } = new List<Episode>();







        public static List<Anime> GenerateAnime()
        {
            return new List<Anime>
            {
                new Anime
                {
                    ID = 1,
                    Title = "Attack on Titan",
                    RelaseDate = new DateTime(2013, 4, 6),
                    Descripton = "Humans fight against Titans to survive.",
                    Genres = new List<Genre> { Genre.Action, Genre.Drama },
                    SeasonCount = 4,
                    IsCompleted = true,
                    AverageRating = 9.1,
                    TotalDuration = TimeSpan.FromHours(30),
                    Episodes = new List<Episode> { new Episode { ID = 1, Title = "To You, in 2000 Years" } }
                },
                new Anime
                {
                    ID = 2,
                    Title = "Naruto",
                    RelaseDate = new DateTime(2002, 10, 3),
                    Descripton = "The story of a ninja seeking recognition and becoming Hokage.",
                    Genres = new List<Genre> { Genre.Action, Genre.Adventure },
                    SeasonCount = 5,
                    IsCompleted = true,
                    AverageRating = 8.6,
                    TotalDuration = TimeSpan.FromHours(72),
                    Episodes = new List<Episode> { new Episode { ID = 1, Title = "Enter: Naruto Uzumaki!" } }
                },
                new Anime
                {
                    ID = 3,
                    Title = "My Hero Academia",
                    RelaseDate = new DateTime(2016, 4, 3),
                    Descripton = "In a world of heroes, one boy strives to become the best.",
                    Genres = new List<Genre> { Genre.Action, Genre.Comedy },
                    SeasonCount = 6,
                    IsCompleted = false,
                    AverageRating = 8.5,
                    TotalDuration = TimeSpan.FromHours(50),
                    Episodes = new List<Episode> { new Episode { ID = 1, Title = "Izuku Midoriya: Origin" } }
                },
                new Anime
                {
                    ID = 4,
                    Title = "Death Note",
                    RelaseDate = new DateTime(2006, 10, 4),
                    Descripton = "A high school student discovers a notebook with deadly powers.",
                    Genres = new List<Genre> { Genre.Drama, Genre.Fantasy },
                    SeasonCount = 1,
                    IsCompleted = true,
                    AverageRating = 9.0,
                    TotalDuration = TimeSpan.FromHours(20),
                    Episodes = new List<Episode> { new Episode { ID = 1, Title = "Rebirth" } }
                },
                new Anime
                {
                    ID = 5,
                    Title = "One Piece",
                    RelaseDate = new DateTime(1999, 10, 20),
                    Descripton = "A pirate's journey to find the ultimate treasure.",
                    Genres = new List<Genre> { Genre.Action, Genre.Adventure },
                    SeasonCount = 20,
                    IsCompleted = false,
                    AverageRating = 8.8,
                    TotalDuration = TimeSpan.FromHours(500),
                    Episodes = new List<Episode> { new Episode { ID = 1, Title = "I’m Luffy! The Man Who’s Gonna Be King of the Pirates!" } }
                },
                new Anime
                {
                    ID = 6,
                    Title = "Demon Slayer",
                    RelaseDate = new DateTime(2019, 4, 6),
                    Descripton = "A boy fights demons to save his sister and avenge his family.",
                    Genres = new List<Genre> { Genre.Action, Genre.Fantasy },
                    SeasonCount = 3,
                    IsCompleted = false,
                    AverageRating = 8.7,
                    TotalDuration = TimeSpan.FromHours(40),
                    Episodes = new List<Episode> { new Episode { ID = 1, Title = "Cruelty" } }
                },
                new Anime
                {
                    ID = 7,
                    Title = "Fullmetal Alchemist: Brotherhood",
                    RelaseDate = new DateTime(2009, 4, 5),
                    Descripton = "Two brothers use alchemy to try to fix their mistakes.",
                    Genres = new List<Genre> { Genre.Action, Genre.Drama },
                    SeasonCount = 1,
                    IsCompleted = true,
                    AverageRating = 9.2,
                    TotalDuration = TimeSpan.FromHours(30),
                    Episodes = new List<Episode> { new Episode { ID = 1, Title = "Fullmetal Alchemist" } }
                },
                new Anime
                {
                    ID = 8,
                    Title = "Sword Art Online",
                    RelaseDate = new DateTime(2012, 7, 8),
                    Descripton = "Players are trapped in a virtual reality MMORPG.",
                    Genres = new List<Genre> { Genre.Action, Genre.SciFi },
                    SeasonCount = 4,
                    IsCompleted = false,
                    AverageRating = 7.5,
                    TotalDuration = TimeSpan.FromHours(40),
                    Episodes = new List<Episode> { new Episode { ID = 1, Title = "The World of Swords" } }
                },
                new Anime
                {
                    ID = 9,
                    Title = "Hunter x Hunter",
                    RelaseDate = new DateTime(2011, 10, 2),
                    Descripton = "A young boy searches for his father while becoming a Hunter.",
                    Genres = new List<Genre> { Genre.Action, Genre.Adventure },
                    SeasonCount = 6,
                    IsCompleted = true,
                    AverageRating = 9.0,
                    TotalDuration = TimeSpan.FromHours(60),
                    Episodes = new List<Episode> { new Episode { ID = 1, Title = "Departure x And x Friends" } }
                },
                new Anime
                {
                    ID = 10,
                    Title = "Dragon Ball Z",
                    RelaseDate = new DateTime(1989, 4, 26),
                    Descripton = "The adventures of Goku and friends as they defend Earth.",
                    Genres = new List<Genre> { Genre.Action, Genre.Adventure },
                    SeasonCount = 9,
                    IsCompleted = true,
                    AverageRating = 8.7,
                    TotalDuration = TimeSpan.FromHours(200),
                    Episodes = new List<Episode> { new Episode { ID = 1, Title = "The New Threat" } }
                }
            };



        }

    }
            
}
