using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace TVCheck.Data
{
    public class Show
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List <Genre> Genres { get; set; }
        public int SeasonCount { get; set; }
        public bool IsCompleted { get; set; }
        public Image Avatar { get; set; }
        public DateTime PremiereDate { get; set; }
        public double AverageRating { get; set; }
        public TimeSpan TotalDuration { get; set; }
        public List<Episode> Episodes { get; set; } = new List<Episode>();
        public List<Rating> Ratings { get; set; } = new List<Rating>();
        public List <Actor> Cast { get; set; } = new List<Actor>(); 
        public List <StreamingService>StreamingServcies { get; set; } = new List<StreamingService>();

        //-----------------------------------------------------------------------------------------------
        public static Show BreakingBad{ get; set; }
        public static Show StrangerThings { get; set; }
        public static Show GameOfThrones { get; set; }
        public static Show ThisIsUs { get; set; }
        public static Show TheOffice { get; set; }
        public static Show Friends { get; set; }
        public static Show TheMandolorian { get; set; }
        public static Show TheCrown { get; set; }
        public static Show TheWitcher { get; set; }
        public static Show Dark { get; set; }
        public static Show BetterCallSaul { get; set; }
        public static Show TheBoys { get; set; }
        public static Show Westworld { get; set; }
        public static Show House { get; set; }
        public static Show Sherlock { get; set; }
        public static Show BlackMirror { get; set; }
        public static Show Suits { get; set; }
        public static Show Vikings { get; set; }
        public static Show MoneyHeist { get; set; }
        public static Show PeakyBlinders { get; set; }

        public static List<Show> GenerateShows()
        {
            BreakingBad = new Show
            {
                ID = 1,
                Title = "Breaking Bad",
                Description = "A high school chemistry teacher turned methamphetamine manufacturer.",
                Genres = new List<Genre> { Genre.Crime, Genre.Drama },
                SeasonCount = 5,
                IsCompleted = true,
                PremiereDate = new DateTime(2008, 1, 20),
                AverageRating = 9.5,
                TotalDuration = TimeSpan.FromHours(50),
                Cast = new List<Actor> { Actor.BryanCranston, Actor.AaronPaul },
                StreamingServcies = new List<StreamingService> { StreamingService.Netflix }
            };
            GameOfThrones = new Show
            {
                ID = 2,
                Title = "Game of Thrones",
                Description = "Nine noble families fight for control of the mythical land of Westeros.",
                Genres = new List<Genre> { Genre.Action, Genre.Adventure, Genre.Drama,Genre.Fantasy },
                SeasonCount = 8,
                IsCompleted = true,
                PremiereDate = new DateTime(2011, 4, 17),
                AverageRating = 9.3,
                TotalDuration = TimeSpan.FromHours(73),
                Cast = new List<Actor> { Actor.PeterDinklage, Actor.EmiliaClarke },
                StreamingServcies = new List<StreamingService> { StreamingService.HBOMax }
            };
            StrangerThings = new Show
            {
                ID = 3,
                Title = "Stranger Things",
                Description = "A group of young friends uncover a supernatural mystery in their small town.",
                Genres = new List<Genre> { Genre.Drama, Genre.Fantasy, Genre.Horror },
                SeasonCount = 4,
                IsCompleted = false,
                PremiereDate = new DateTime(2016, 7, 15),
                AverageRating = 8.8,
                TotalDuration = TimeSpan.FromHours(36),
                Cast = new List<Actor> { Actor.MillieBobbyBrown, Actor.WinonaRyder },
                StreamingServcies = new List<StreamingService> { StreamingService.Netflix }
            };
            ThisIsUs = new Show
            {
                ID = 4,
                Title = "This Is Us",
                Description = "A family drama series following the lives of the Pearson family.",
                Genres = new List<Genre> { Genre.Drama },
                SeasonCount = 6,
                IsCompleted = true,
                PremiereDate = new DateTime(2016, 9, 20),
                AverageRating = 8.7,
                TotalDuration = TimeSpan.FromHours(60),
                Cast = new List<Actor> { Actor.MandyMoore, Actor.SterlingKBrown },
                StreamingServcies = new List<StreamingService> { StreamingService.Hulu }
            };
            TheOffice = new Show
            {
                ID = 5,
                Title = "The Office",
                Description = "A mockumentary on a group of typical office workers, depicting their everyday lives.",
                Genres = new List<Genre> { Genre.Comedy },
                SeasonCount = 9,
                IsCompleted = true,
                PremiereDate = new DateTime(2005, 3, 24),
                AverageRating = 8.9,
                TotalDuration = TimeSpan.FromHours(110),
                Cast = new List<Actor> { Actor.SteveCarell, Actor.JohnKrasinski },
                StreamingServcies = new List<StreamingService> { StreamingService.Peacock }
            };
            Friends = new Show
            {
                ID = 6,
                Title = "Friends",
                Description = "Six friends navigate life and love in New York City.",
                Genres = new List<Genre> { Genre.Comedy, Genre.Romance },
                SeasonCount = 10,
                IsCompleted = true,
                PremiereDate = new DateTime(1994, 9, 22),
                AverageRating = 8.9,
                TotalDuration = TimeSpan.FromHours(88),
                Cast = new List<Actor> { Actor.JenniferAniston, Actor.MattLeBlanc },
                StreamingServcies = new List<StreamingService> { StreamingService.HBOMax }
            };
            TheMandolorian = new Show
            {
                ID = 7,
                Title = "The Mandalorian",
                Description = "The adventures of a lone bounty hunter in the outer reaches of the galaxy.",
                Genres = new List<Genre> { Genre.Action, Genre.Adventure, Genre.SciFi },
                SeasonCount = 2,
                IsCompleted = false,
                PremiereDate = new DateTime(2019, 11, 12),
                AverageRating = 8.7,
                TotalDuration = TimeSpan.FromHours(20),
                Cast = new List<Actor> { Actor.PedroPascal, Actor.GinaCarano },
                StreamingServcies = new List<StreamingService> { StreamingService.DisneyPlus }
            };
            TheCrown = new Show
            {
                ID = 8,
                Title = "The Crown",
                Description = "The story of Queen Elizabeth II's reign and her role in shaping modern Britain.",
                Genres = new List<Genre> { Genre.Drama, Genre.Historical },
                SeasonCount = 4,
                IsCompleted = false,
                PremiereDate = new DateTime(2016, 11, 4),
                AverageRating = 8.7,
                TotalDuration = TimeSpan.FromHours(40),
                Cast = new List<Actor> { Actor.ClaireFoy, Actor.MattSmith },
                StreamingServcies = new List<StreamingService> { StreamingService.Netflix }
            };
            TheWitcher = new Show
            {
                ID = 9,
                Title = "The Witcher",
                Description = "Geralt of Rivia, a monster hunter, must navigate a world full of dangerous creatures and moral dilemmas.",
                Genres = new List<Genre> { Genre.Action, Genre.Fantasy },
                SeasonCount = 2,
                IsCompleted = false,
                PremiereDate = new DateTime(2019, 12, 20),
                AverageRating = 8.2,
                TotalDuration = TimeSpan.FromHours(16),
                Cast = new List<Actor> { Actor.HenryCavill, Actor.AnyaChalotra },
                StreamingServcies = new List<StreamingService> { StreamingService.Netflix }
            };
            Dark = new Show
            {
                ID = 10,
                Title = "Dark",
                Description = "A time travel mystery that explores the interconnectedness of four estranged families.",
                Genres = new List<Genre> { Genre.Mystery, Genre.SciFi, Genre.Thriller },
                SeasonCount = 3,
                IsCompleted = true,
                PremiereDate = new DateTime(2017, 12, 1),
                AverageRating = 8.8,
                TotalDuration = TimeSpan.FromHours(30),
                Cast = new List<Actor> { Actor.LuisKnebel, Actor.CleopatraCole },
                StreamingServcies = new List<StreamingService> { StreamingService.Netflix }
            };
            BetterCallSaul = new Show
            {
                ID = 11,
                Title = "Better Call Saul",
                Description = "The transformation of Jimmy McGill into Saul Goodman, the shady lawyer from Breaking Bad.",
                Genres = new List<Genre> { Genre.Crime, Genre.Drama },
                SeasonCount = 6,
                IsCompleted = true,
                PremiereDate = new DateTime(2015, 2, 8),
                AverageRating = 8.9,
                TotalDuration = TimeSpan.FromHours(63),
                Cast = new List<Actor> { Actor.BobOdenkirk, Actor.RheaSeehorn },
                StreamingServcies = new List<StreamingService> { StreamingService.Netflix }
            };
            TheBoys = new Show
            {
                ID = 12,
                Title = "The Boys",
                Description = "A dark satire on superheroes and their corrupt world.",
                Genres = new List<Genre> { Genre.Action, Genre.Drama, Genre.Comedy },
                SeasonCount = 3,
                IsCompleted = false,
                PremiereDate = new DateTime(2019, 7, 26),
                AverageRating = 8.7,
                TotalDuration = TimeSpan.FromHours(24),
                Cast = new List<Actor> { Actor.KarlUrban, Actor.JackQuaid },
                StreamingServcies = new List<StreamingService> { StreamingService.AmazonPrime }
            };
            Westworld = new Show
            {
                ID = 13,
                Title = "Westworld",
                Description = "A futuristic theme park where robots gain consciousness and chaos ensues.",
                Genres = new List<Genre> { Genre.Drama, Genre.SciFi },
                SeasonCount = 4,
                IsCompleted = false,
                PremiereDate = new DateTime(2016, 10, 2),
                AverageRating = 8.6,
                TotalDuration = TimeSpan.FromHours(42),
                Cast = new List<Actor> { Actor.EvanRachelWood, Actor.AnthonyHopkins },
                StreamingServcies = new List<StreamingService> { StreamingService.HBOMax }
            };
            House = new Show
            {
                ID = 14,
                Title = "House",
                Description = "A brilliant but misanthropic doctor solves medical mysteries.",
                Genres = new List<Genre> { Genre.Drama, Genre.Medical },
                SeasonCount = 8,
                IsCompleted = true,
                PremiereDate = new DateTime(2004, 11, 16),
                AverageRating = 8.7,
                TotalDuration = TimeSpan.FromHours(131),
                Cast = new List<Actor> { Actor.HughLaurie, Actor.OmarEpps },
                StreamingServcies = new List<StreamingService> { StreamingService.Peacock }
            };
            Sherlock = new Show
            {
                ID = 15,
                Title = "Sherlock",
                Description = "A modern retelling of the classic Sherlock Holmes detective stories.",
                Genres = new List<Genre> { Genre.Crime, Genre.Drama, Genre.Mystery },
                SeasonCount = 4,
                IsCompleted = true,
                PremiereDate = new DateTime(2010, 7, 25),
                AverageRating = 9.1,
                TotalDuration = TimeSpan.FromHours(18),
                Cast = new List<Actor> { Actor.BenedictCumberbatch, Actor.MartinFreeman },
                StreamingServcies = new List<StreamingService> { StreamingService.Netflix }
            };
            BlackMirror = new Show
            {
                ID = 16,
                Title = "Black Mirror",
                Description = "An anthology series that explores modern society's relationship with technology.",
                Genres = new List<Genre> { Genre.SciFi, Genre.Drama },
                SeasonCount = 5,
                IsCompleted = false,
                PremiereDate = new DateTime(2011, 12, 4),
                AverageRating = 8.8,
                TotalDuration = TimeSpan.FromHours(22),
                Cast = new List<Actor> { Actor.JonHamm, Actor.MackenzieDavis },
                StreamingServcies = new List<StreamingService> { StreamingService.Netflix }
            };
            Suits = new Show
            {
                ID = 17,
                Title = "Suits",
                Description = "A talented college dropout works with a brilliant lawyer at a high-profile law firm.",
                Genres = new List<Genre> { Genre.Drama },
                SeasonCount = 9,
                IsCompleted = true,
                PremiereDate = new DateTime(2011, 6, 23),
                AverageRating = 8.5,
                TotalDuration = TimeSpan.FromHours(135),
                Cast = new List<Actor> { Actor.GabrielMacht, Actor.PatrickJAdams },
                StreamingServcies = new List<StreamingService> { StreamingService.Netflix }
            };
            Vikings = new Show
            {
                ID = 18,
                Title = "Vikings",
                Description = "The legendary Norse hero Ragnar Lothbrok and his adventures.",
                Genres = new List<Genre> { Genre.Action, Genre.Drama, Genre.Historical },
                SeasonCount = 6,
                IsCompleted = true,
                PremiereDate = new DateTime(2013, 3, 3),
                AverageRating = 8.5,
                TotalDuration = TimeSpan.FromHours(89),
                Cast = new List<Actor> { Actor.TravisFimmel, Actor.KatherynWinnick },
                StreamingServcies = new List<StreamingService> { StreamingService.Netflix }
            };
            MoneyHeist = new Show
            {
                ID = 19,
                Title = "Money Heist",
                Description = "A criminal mastermind orchestrates a major heist on Spain's Royal Mint.",
                Genres = new List<Genre> { Genre.Crime, Genre.Drama, Genre.Thriller },
                SeasonCount = 5,
                IsCompleted = true,
                PremiereDate = new DateTime(2017, 5, 2),
                AverageRating = 8.2,
                TotalDuration = TimeSpan.FromHours(41),
                Cast = new List<Actor> { Actor.AlvaroMorte, Actor.UrsulaCorbero },
                StreamingServcies = new List<StreamingService> { StreamingService.Netflix }
            };
            PeakyBlinders = new Show
            {
                ID = 20,
                Title = "Peaky Blinders",
                Description = "The story of a gangster family in Birmingham, England, after World War I.",
                Genres = new List<Genre> { Genre.Crime, Genre.Drama },
                SeasonCount = 6,
                IsCompleted = true,
                PremiereDate = new DateTime(2013, 9, 12),
                AverageRating = 8.8,
                TotalDuration = TimeSpan.FromHours(36),
                Cast = new List<Actor> { Actor.CillianMurphy, Actor.HelenMcCrory },
                StreamingServcies = new List<StreamingService> { StreamingService.Netflix }
            };

            return new List<Show>{
               BreakingBad, GameOfThrones, StrangerThings, ThisIsUs, TheOffice,
                Friends, TheMandolorian, TheCrown, TheWitcher, Dark,BetterCallSaul, TheBoys, Westworld, House, 
                Sherlock, BlackMirror, Suits, Vikings, MoneyHeist, PeakyBlinders
            };

        }





    }

}
