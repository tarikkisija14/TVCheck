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



        // Metoda za generisanje svih glumaca
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

            return new List<Actor>
            {
                BryanCranston, AaronPaul, PeterDinklage, EmiliaClarke, MandyMoore,
                SterlingKBrown, JaredPadalecki, JensenAckles, MillieBobbyBrown, WinonaRyder,
                KitHarington, JodieComer, SandraOh, JeffreyDeanMorgan, NormanReedus
            };
        }
    }
}