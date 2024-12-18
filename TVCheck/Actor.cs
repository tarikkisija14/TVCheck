using System.Drawing;

namespace TVCheck.Data
{
    public class Actor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Biography { get; set; }
        public List<Show> Shows { get; set; } = new List<Show>();
        public List<string> Awards { get; set; } = new List<string>();

        public Image Avatar { get; set; }


        //ActorProps
        public static Actor BryanCranston { get; set; }
        public static Actor AaronPaul { get; set; }
        public static Actor PeterDinklage { get; set; }
        public static Actor EmiliaClarke { get; set; }
        public static Actor MandyMoore { get; set; }
        public static Actor SterlingKBrown { get; set; }
        public static Actor JaredPadalecki { get; set; }
        public static Actor JensenAckles { get; set; }
        public static Actor MillieBobbyBrown { get; set; }
        public static Actor WinonaRyder { get; set; }
        public static Actor KitHarington { get; set; }
        public static Actor JodieComer { get; set; }
        public static Actor SandraOh { get; set; }
        public static Actor JeffreyDeanMorgan { get; set; }
        public static Actor NormanReedus { get; set; }
        public static Actor SteveCarell { get; set; }
        public static Actor PedroPascal { get; set; }
        public static Actor JohnKrasinski { get; internal set; }
        public static Actor MattLeBlanc { get; internal set; }
        public static Actor JenniferAniston { get; internal set; }
        public static Actor GinaCarano { get; internal set; }
        public static Actor HenryCavill { get; internal set; }
        public static Actor AnyaChalotra { get; internal set; }
        public static Actor LuisKnebel { get; internal set; }
        public static Actor CleopatraCole { get; internal set; }
        public static Actor ClaireFoy { get; internal set; }
        public static Actor MattSmith { get; internal set; }
        public static Actor BobOdenkirk { get; internal set; }
        public static Actor RheaSeehorn { get; internal set; }
        public static Actor KarlUrban { get; internal set; }
        public static Actor JackQuaid { get; internal set; }
        public static Actor EvanRachelWood { get; internal set; }
        public static Actor AnthonyHopkins { get; internal set; }
        public static Actor HughLaurie { get; internal set; }
        public static Actor OmarEpps { get; internal set; }
        public static Actor BenedictCumberbatch { get; internal set; }
        public static Actor MartinFreeman { get; internal set; }
        public static Actor JonHamm { get; internal set; }
        public static Actor MackenzieDavis { get; internal set; }
        public static Actor GabrielMacht { get; internal set; }
        public static Actor PatrickJAdams { get; internal set; }
        public static Actor TravisFimmel { get; internal set; }
        public static Actor KatherynWinnick { get; internal set; }
        public static Actor AlvaroMorte { get; internal set; }
        public static Actor UrsulaCorbero { get; internal set; }
        public static Actor CillianMurphy { get; internal set; }
        public static Actor HelenMcCrory { get; internal set; }
        public static Actor NickOfferman { get; internal set; }
        public static Actor AmyPoehler { get; internal set; }
        public static Actor CasAnvar { get; internal set; }
        public static Actor StevenStrait { get; internal set; }
        public static Actor WoodyHarrelson { get; internal set; }
        public static Actor MatthewMcConaughey { get; internal set; }
        public static Actor BillyBobThornton { get; internal set; }
        public static Actor LorraineBracco { get; internal set; }
        public static Actor JamesGandolfini { get; internal set; }
        public static Actor IdrisElba { get; internal set; }

        public static Actor DominicWest { get; internal set; }
        public static Actor ElisabethMoss { get; internal set; }

        




        public static List<Actor> GenerateActors()
        {
            BryanCranston = new Actor
            {
                ID = 1,
                Name = "Bryan Cranston",
                BirthDate = new DateTime(1956, 3, 7),
                Biography = "Bryan Cranston is known for his role as Walter White in Breaking Bad.",
                Awards = new List<string> { "Primetime Emmy Award", "Golden Globe Award" }
            };

            AaronPaul = new Actor
            {
                ID = 2,
                Name = "Aaron Paul",
                BirthDate = new DateTime(1979, 8, 27),
                Biography = "Aaron Paul is known for playing Jesse Pinkman in Breaking Bad.",
                Awards = new List<string> { "Primetime Emmy Award" }
            };

            PeterDinklage = new Actor
            {
                ID = 3,
                Name = "Peter Dinklage",
                BirthDate = new DateTime(1969, 6, 11),
                Biography = "Peter Dinklage is best known for his role as Tyrion Lannister in Game of Thrones.",
                Awards = new List<string> { "Primetime Emmy Award" }
            };

            EmiliaClarke = new Actor
            {
                ID = 4,
                Name = "Emilia Clarke",
                BirthDate = new DateTime(1986, 10, 23),
                Biography = "Emilia Clarke is best known for portraying Daenerys Targaryen in Game of Thrones.",
                Awards = new List<string> { "Primetime Emmy Award" }
            };

            MandyMoore = new Actor
            {
                ID = 5,
                Name = "Mandy Moore",
                BirthDate = new DateTime(1984, 4, 10),
                Biography = "Mandy Moore stars as Rebecca Pearson in This Is Us.",
                Awards = new List<string> { "Teen Choice Award", "People's Choice Award" }
            };

            SterlingKBrown = new Actor
            {
                ID = 6,
                Name = "Sterling K. Brown",
                BirthDate = new DateTime(1976, 4, 5),
                Biography = "Sterling K. Brown is known for his role as Randall Pearson in This Is Us.",
                Awards = new List<string> { "Primetime Emmy Award" }
            };

            JaredPadalecki = new Actor
            {
                ID = 7,
                Name = "Jared Padalecki",
                BirthDate = new DateTime(1982, 7, 19),
                Biography = "Jared Padalecki is best known for playing Sam Winchester in Supernatural.",
                Awards = new List<string> { "Teen Choice Award", "People's Choice Award" }
            };

            JensenAckles = new Actor
            {
                ID = 8,
                Name = "Jensen Ackles",
                BirthDate = new DateTime(1978, 3, 1),
                Biography = "Jensen Ackles starred as Dean Winchester in Supernatural.",
                Awards = new List<string> { "Teen Choice Award", "People's Choice Award" }
            };

            MillieBobbyBrown = new Actor
            {
                ID = 9,
                Name = "Millie Bobby Brown",
                BirthDate = new DateTime(2004, 2, 19),
                Biography = "Millie Bobby Brown is known for playing Eleven in Stranger Things.",
                Awards = new List<string> { "Screen Actors Guild Award" }
            };

            WinonaRyder = new Actor
            {
                ID = 10,
                Name = "Winona Ryder",
                BirthDate = new DateTime(1971, 10, 29),
                Biography = "Winona Ryder stars as Joyce Byers in Stranger Things.",
                Awards = new List<string> { "Golden Globe Award", "Screen Actors Guild Award" }
            };

            KitHarington = new Actor
            {
                ID = 11,
                Name = "Kit Harington",
                BirthDate = new DateTime(1986, 12, 26),
                Biography = "Kit Harington is best known for his role as Jon Snow in Game of Thrones.",
                Awards = new List<string> { "Golden Globe Award", "Screen Actors Guild Award" }
            };

            JodieComer = new Actor
            {
                ID = 12,
                Name = "Jodie Comer",
                BirthDate = new DateTime(1993, 3, 11),
                Biography = "Jodie Comer is best known for her role as Villanelle in Killing Eve.",
                Awards = new List<string> { "Primetime Emmy Award" }
            };

            SandraOh = new Actor
            {
                ID = 13,
                Name = "Sandra Oh",
                BirthDate = new DateTime(1971, 7, 20),
                Biography = "Sandra Oh is famous for playing Eve Polastri in Killing Eve.",
                Awards = new List<string> { "Golden Globe Award", "Primetime Emmy Award" }
            };

            JeffreyDeanMorgan = new Actor
            {
                ID = 14,
                Name = "Jeffrey Dean Morgan",
                BirthDate = new DateTime(1966, 4, 22),
                Biography = "Jeffrey Dean Morgan is known for his role as Negan in The Walking Dead.",
                Awards = new List<string> { "Saturn Award" }
            };

            NormanReedus = new Actor
            {
                ID = 15,
                Name = "Norman Reedus",
                BirthDate = new DateTime(1969, 1, 6),
                Biography = "Norman Reedus is best known for playing Daryl Dixon in The Walking Dead.",
                Awards = new List<string> { "Saturn Award", "Teen Choice Award" }
            };
            PedroPascal = new Actor
            {
                ID = 16,
                Name = "Pedro Pascal",
                BirthDate = new DateTime(1975, 4, 2),
                Biography = "Pedro Pascal is known for his roles in The Mandalorian and Game of Thrones.",
                Awards = new List<string> { "Primetime Emmy Award" }
            };

            JohnKrasinski = new Actor
            {
                ID = 17,
                Name = "John Krasinski",
                BirthDate = new DateTime(1979, 10, 20),
                Biography = "John Krasinski is known for his role as Jim Halpert in The Office.",
                Awards = new List<string> { "Screen Actors Guild Award" }
            };

            MattLeBlanc = new Actor
            {
                ID = 18,
                Name = "Matt LeBlanc",
                BirthDate = new DateTime(1967, 7, 25),
                Biography = "Matt LeBlanc is best known for his role as Joey Tribbiani in Friends.",
                Awards = new List<string> { "Golden Globe Award" }
            };

            JenniferAniston = new Actor
            {
                ID = 19,
                Name = "Jennifer Aniston",
                BirthDate = new DateTime(1969, 2, 11),
                Biography = "Jennifer Aniston is famous for her role as Rachel Green in Friends.",
                Awards = new List<string> { "Golden Globe Award", "Screen Actors Guild Award" }
            };

            GinaCarano = new Actor
            {
                ID = 20,
                Name = "Gina Carano",
                BirthDate = new DateTime(1982, 4, 16),
                Biography = "Gina Carano is known for her role in The Mandalorian and as a former MMA fighter.",
                Awards = new List<string> { "Cineplex Golden Screen Award" }
            };

            HenryCavill = new Actor
            {
                ID = 21,
                Name = "Henry Cavill",
                BirthDate = new DateTime(1983, 5, 5),
                Biography = "Henry Cavill is known for playing Superman in the DC Universe and Geralt of Rivia in The Witcher.",
                Awards = new List<string> { "Golden Globe Award" }
            };

            AnyaChalotra = new Actor
            {
                ID = 22,
                Name = "Anya Chalotra",
                BirthDate = new DateTime(1996, 7, 21),
                Biography = "Anya Chalotra is best known for her role as Yennefer of Vengerberg in The Witcher.",
                Awards = new List<string> { "Nominated for a BAFTA" }
            };

            LuisKnebel = new Actor
            {
                ID = 23,
                Name = "Luis Knebel",
                BirthDate = new DateTime(1984, 9, 3),
                Biography = "Luis Knebel is known for his role in international films.",
                Awards = new List<string> { "Best Actor in a Supporting Role" }
            };

            CleopatraCole = new Actor
            {
                ID = 24,
                Name = "Cleopatra Cole",
                BirthDate = new DateTime(1992, 2, 11),
                Biography = "Cleopatra Cole is an emerging talent in international series.",
                Awards = new List<string> { "Best Newcomer" }
            };
            
            ClaireFoy = new Actor
            {
                ID = 25,
                Name = "Claire Foy",
                BirthDate = new DateTime(1984, 4, 16),
                Biography = "Claire Foy is known for playing Queen Elizabeth II in The Crown.",
                Awards = new List<string> { "Golden Globe Award", "Primetime Emmy Award" }
            };
            
            MattSmith = new Actor
            {
                ID = 26,
                Name = "Matt Smith",
                BirthDate = new DateTime(1982, 10, 28),
                Biography = "Matt Smith is best known for his role as the Eleventh Doctor in Doctor Who.",
                Awards = new List<string> { "National Television Award", "BAFTA TV Award" }
            };

            ClaireFoy = new Actor
            {
                ID = 27,
                Name = "Claire Foy",
                BirthDate = new DateTime(1984, 4, 16),
                Biography = "Claire Foy is known for playing Queen Elizabeth II in The Crown.",
                Awards = new List<string> { "Golden Globe Award", "Primetime Emmy Award" }
            };
            BobOdenkirk = new Actor
            {
                ID = 28,
                Name = "Bob Odenkirk",
                BirthDate = new DateTime(1962, 10, 22),
                Biography = "Bob Odenkirk is known for his role as Saul Goodman in Better Call Saul.",
                Awards = new List<string> { "Primetime Emmy Award" }
            };

            RheaSeehorn = new Actor
            {
                ID = 29,
                Name = "Rhea Seehorn",
                BirthDate = new DateTime(1972, 5, 12),
                Biography = "Rhea Seehorn is known for her role as Kim Wexler in Better Call Saul.",
                Awards = new List<string> { "Critics' Choice Award" }
            };

            KarlUrban = new Actor
            {
                ID = 30,
                Name = "Karl Urban",
                BirthDate = new DateTime(1972, 6, 7),
                Biography = "Karl Urban is known for his role as Billy Butcher in The Boys.",
                Awards = new List<string> { "Saturn Award" }
            };

            JackQuaid = new Actor
            {
                ID = 31,
                Name = "Jack Quaid",
                BirthDate = new DateTime(1992, 4, 24),
                Biography = "Jack Quaid is known for his role as Hughie Campbell in The Boys.",
                Awards = new List<string> { "Critics' Choice Award" }
            };

            EvanRachelWood = new Actor
            {
                ID = 32,
                Name = "Evan Rachel Wood",
                BirthDate = new DateTime(1987, 9, 7),
                Biography = "Evan Rachel Wood is known for her role as Dolores Abernathy in Westworld.",
                Awards = new List<string> { "Golden Globe Award" }
            };

            AnthonyHopkins = new Actor
            {
                ID = 33,
                Name = "Anthony Hopkins",
                BirthDate = new DateTime(1937, 12, 31),
                Biography = "Anthony Hopkins is known for his role as Dr. Hannibal Lecter in The Silence of the Lambs.",
                Awards = new List<string> { "Academy Award", "BAFTA Award" }
            };

            HughLaurie = new Actor
            {
                ID = 34,
                Name = "Hugh Laurie",
                BirthDate = new DateTime(1959, 6, 11),
                Biography = "Hugh Laurie is known for his role as Dr. Gregory House in House.",
                Awards = new List<string> { "Golden Globe Award" }
            };

            OmarEpps = new Actor
            {
                ID = 35,
                Name = "Omar Epps",
                BirthDate = new DateTime(1973, 7, 20),
                Biography = "Omar Epps is known for his role as Dr. Eric Foreman in House.",
                Awards = new List<string> { "NAACP Image Award" }
            };

            BenedictCumberbatch = new Actor
            {
                ID = 36,
                Name = "Benedict Cumberbatch",
                BirthDate = new DateTime(1976, 7, 19),
                Biography = "Benedict Cumberbatch is known for his role as Sherlock Holmes in Sherlock.",
                Awards = new List<string> { "BAFTA Award", "Primetime Emmy Award" }
            };

            MartinFreeman = new Actor
            {
                ID = 37,
                Name = "Martin Freeman",
                BirthDate = new DateTime(1971, 9, 8),
                Biography = "Martin Freeman is known for his role as Dr. John Watson in Sherlock.",
                Awards = new List<string> { "BAFTA Award", "Screen Actors Guild Award" }
            };

            JonHamm = new Actor
            {
                ID = 38,
                Name = "Jon Hamm",
                BirthDate = new DateTime(1971, 3, 10),
                Biography = "Jon Hamm is known for his role as Don Draper in Mad Men.",
                Awards = new List<string> { "Golden Globe Award", "Primetime Emmy Award" }
            };

            MackenzieDavis = new Actor
            {
                ID = 39,
                Name = "Mackenzie Davis",
                BirthDate = new DateTime(1987, 4, 1),
                Biography = "Mackenzie Davis is known for her role as Cameron Howe in Halt and Catch Fire.",
                Awards = new List<string> { "Critics' Choice Award" }
            };

            GabrielMacht = new Actor
            {
                ID = 40,
                Name = "Gabriel Macht",
                BirthDate = new DateTime(1972, 1, 22),
                Biography = "Gabriel Macht is known for his role as Harvey Specter in Suits.",
                Awards = new List<string> { "People's Choice Award" }
            };

            PatrickJAdams = new Actor
            {
                ID = 41,
                Name = "Patrick J. Adams",
                BirthDate = new DateTime(1981, 8, 27),
                Biography = "Patrick J. Adams is known for his role as Mike Ross in Suits.",
                Awards = new List<string> { "Screen Actors Guild Award" }
            };

            TravisFimmel = new Actor
            {
                ID = 42,
                Name = "Travis Fimmel",
                BirthDate = new DateTime(1979, 7, 15),
                Biography = "Travis Fimmel is known for his role as Ragnar Lothbrok in Vikings.",
                Awards = new List<string> { "Critics' Choice Award" }
            };

            KatherynWinnick = new Actor
            {
                ID = 43,
                Name = "Katheryn Winnick",
                BirthDate = new DateTime(1977, 12, 17),
                Biography = "Katheryn Winnick is known for her role as Lagertha in Vikings.",
                Awards = new List<string> { "Golden Maple Award" }
            };

            AlvaroMorte = new Actor
            {
                ID = 44,
                Name = "Alvaro Morte",
                BirthDate = new DateTime(1975, 2, 23),
                Biography = "Alvaro Morte is best known for his role as The Professor in La Casa de Papel.",
                Awards = new List<string> { "Premio 40 Principales", "Best Actor in a Leading Role" }
            };

            UrsulaCorbero = new Actor
            {
                ID = 45,
                Name = "Ursula Corbero",
                BirthDate = new DateTime(1989, 8, 11),
                Biography = "Ursula Corbero is widely recognized for her portrayal of Tokyo in La Casa de Papel.",
                Awards = new List<string> { "Best Actress", "Nominated for Ondas Award" }
            };

            CillianMurphy = new Actor
            {
                ID = 46,
                Name = "Cillian Murphy",
                BirthDate = new DateTime(1976, 5, 25),
                Biography = "Cillian Murphy is an Irish actor, best known for his roles in Peaky Blinders and Inception.",
                Awards = new List<string> { "Cork Film Festival Award", "Best Supporting Actor" }
            };

            HelenMcCrory = new Actor
            {
                ID = 47,
                Name = "Helen McCrory",
                BirthDate = new DateTime(1968, 8, 17),
                Biography = "Helen McCrory was an English actress known for her role in Peaky Blinders and Harry Potter.",
                Awards = new List<string> { "Best Actress Nominee", "British Academy Television Award" }
            };

            ElisabethMoss = new Actor
            {
                ID = 48,
                Name = "Elisabeth Moss",
                BirthDate = new DateTime(1982, 7, 24),
                Biography = "Elisabeth Moss is known for her roles in The Handmaid's Tale and Mad Men.",
                Awards = new List<string> { "Primetime Emmy Award", "Golden Globe Award" }
            };

            DominicWest = new Actor
            {
                ID = 49,
                Name = "Dominic West",
                BirthDate = new DateTime(1969, 10, 15),
                Biography = "Dominic West is famous for his role as Jimmy McNulty in The Wire.",
                Awards = new List<string> { "BAFTA Award" }
            };

            IdrisElba = new Actor
            {
                ID = 50,
                Name = "Idris Elba",
                BirthDate = new DateTime(1972, 9, 6),
                Biography = "Idris Elba is known for his roles in Luther and The Wire.",
                Awards = new List<string> { "Golden Globe Award", "Screen Actors Guild Award" }
            };

            JamesGandolfini = new Actor
            {
                ID = 51,
                Name = "James Gandolfini",
                BirthDate = new DateTime(1961, 9, 18),
                Biography = "James Gandolfini is best known for his role as Tony Soprano in The Sopranos.",
                Awards = new List<string> { "Primetime Emmy Award", "Golden Globe Award" }
            };

            LorraineBracco = new Actor
            {
                ID = 52,
                Name = "Lorraine Bracco",
                BirthDate = new DateTime(1954, 10, 2),
                Biography = "Lorraine Bracco is known for her role as Dr. Melfi in The Sopranos.",
                Awards = new List<string> { "Screen Actors Guild Award" }
            };

            BillyBobThornton = new Actor
            {
                ID = 53,
                Name = "Billy Bob Thornton",
                BirthDate = new DateTime(1955, 8, 4),
                Biography = "Billy Bob Thornton is famous for his role in Fargo (TV series) and Sling Blade.",
                Awards = new List<string> { "Academy Award", "Golden Globe Award" }
            };

            
            MatthewMcConaughey = new Actor
            {
                ID = 55,
                Name = "Matthew McConaughey",
                BirthDate = new DateTime(1969, 11, 4),
                Biography = "Matthew McConaughey is famous for his role as Rust Cohle in True Detective.",
                Awards = new List<string> { "Academy Award", "Golden Globe Award" }
            };

            WoodyHarrelson = new Actor
            {
                ID = 56,
                Name = "Woody Harrelson",
                BirthDate = new DateTime(1961, 7, 23),
                Biography = "Woody Harrelson is known for his roles in True Detective and Zombieland.",
                Awards = new List<string> { "Primetime Emmy Award", "Nominated for Academy Award" }
            };

            StevenStrait = new Actor
            {
                ID = 57,
                Name = "Steven Strait",
                BirthDate = new DateTime(1986, 3, 23),
                Biography = "Steven Strait is best known for his role as James Holden in The Expanse.",
                Awards = new List<string> { "Nominated for Saturn Award" }
            };

            CasAnvar = new Actor
            {
                ID = 58,
                Name = "Cas Anvar",
                BirthDate = new DateTime(1966, 3, 15),
                Biography = "Cas Anvar is known for his role as Alex Kamal in The Expanse.",
                Awards = new List<string> { "Nominated for Canadian Screen Award" }
            };

            AmyPoehler = new Actor
            {
                ID = 59,
                Name = "Amy Poehler",
                BirthDate = new DateTime(1971, 9, 16),
                Biography = "Amy Poehler is famous for her role as Leslie Knope in Parks and Recreation.",
                Awards = new List<string> { "Golden Globe Award", "Primetime Emmy Award" }
            };

            NickOfferman = new Actor
            {
                ID = 60,
                Name = "Nick Offerman",
                BirthDate = new DateTime(1970, 6, 26),
                Biography = "Nick Offerman is best known for his role as Ron Swanson in Parks and Recreation.",
                Awards = new List<string> { "Critics' Choice Award" }
            };


            return new List<Actor>
            {
                 BryanCranston, AaronPaul, PeterDinklage, EmiliaClarke, MandyMoore,
                 SterlingKBrown, JaredPadalecki, JensenAckles, MillieBobbyBrown, WinonaRyder,
                 KitHarington, JodieComer, SandraOh, JeffreyDeanMorgan, NormanReedus,
                 BobOdenkirk, RheaSeehorn, KarlUrban, JackQuaid, EvanRachelWood,
                 AnthonyHopkins, HughLaurie, OmarEpps, BenedictCumberbatch, MartinFreeman,
                 JonHamm, MackenzieDavis, GabrielMacht, PatrickJAdams, TravisFimmel, KatherynWinnick,
                 AlvaroMorte, UrsulaCorbero, CillianMurphy, HelenMcCrory,NickOfferman,AmyPoehler,CasAnvar,
                 StevenStrait,WoodyHarrelson,MatthewMcConaughey,BillyBobThornton, LorraineBracco,
                 JamesGandolfini,IdrisElba,DominicWest,ElisabethMoss


            };
        }
    }
}