using System.Drawing;

namespace TVCheck.Data
{
    public class StreamingService
    {
        

        public int ID { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public double MonthlyPrice { get; set; }
        public string Website { get; set; }
        public List<Show> Shows { get; set; } = new List<Show>();
        public Image Avatar { get; set; }
        public static StreamingService Netflix { get; set; }
        public static StreamingService HBOMax { get; set; }
        public static StreamingService AmazonPrime { get; set; }
        public static StreamingService DisneyPlus { get; set; }
        public static StreamingService Hulu { get; set; }
        public static StreamingService Peacock { get; internal set; }

        public static List<StreamingService> GenerateStreamingServices()
        {
            Netflix = new StreamingService
            {
                ID = 1,
                Name = "Netflix",
                Country = "Global",
                MonthlyPrice = 9.99,
                Website = "https://www.netflix.com",
                Shows = new List<Show>() { Show.BreakingBad,Show.StrangerThings,Show.TheCrown,Show.TheWitcher,Show.Dark}
            };

            HBOMax = new StreamingService
            {
                ID = 2,
                Name = "HBO MAX",
                Country = "Global",
                MonthlyPrice = 14.99,
                Website = "https://www.hbomax.com",
                Shows = new List<Show>() { Show.GameOfThrones,Show.Friends,}
            };

            AmazonPrime = new StreamingService
            {
                ID = 3,
                Name = "Amazon Prime Video",
                Country = "Global",
                MonthlyPrice = 12.99,
                Website = "https://www.primevideo.com",
                Shows = new List<Show>() {}
            };

            DisneyPlus = new StreamingService
            {
                ID = 4,
                Name = "Disney+",
                Country = "Global",
                MonthlyPrice = 7.99,
                Website = "https://www.disneyplus.com",
                Shows = new List<Show>() { Show.TheMandolorian }
            };

            Hulu = new StreamingService
            {
                ID = 5,
                Name = "Hulu",
                Country = "USA",
                MonthlyPrice = 11.99,
                Website = "https://www.hulu.com",
                Shows = new List<Show>() { Show.ThisIsUs}
            };
            Peacock = new StreamingService
            {
                ID = 6,
                Name = "Peacock",
                Country = "USA",
                MonthlyPrice = 7.99,
                Website = "https://www.peacocktv.com",
                Shows = new List<Show>() { Show.TheOffice }
            };

            return new List<StreamingService> { Netflix, HBOMax, AmazonPrime, DisneyPlus, Hulu,Peacock };
        }
    }


}


    
    
