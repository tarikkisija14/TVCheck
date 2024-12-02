using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVCheck.Data
{
    public class Genre
    {
        public int ID {  get; set; }    
        public string Name { get; set; }    
        public string Description { get; set; } 
        public List<Show> Shows { get; set; }=new List<Show>();

        public static Genre Drama { get; set; }
        public static Genre Comedy{ get; set; }
        public static Genre Action { get; set; }
        public static Genre Adventure { get; set; }
        public static Genre Fantasy { get; set; }
        public static Genre SciFi { get; set; }
        public static Genre Mystery { get; set; }
        public static Genre Horror { get; set; }
        public static Genre Thriller { get; set; }
        public static Genre Romance { get; set; }
        public static Genre Crime { get; set; }
        public static Genre Documentary { get; set; }
        public static Genre Anime { get; set; }
        public static Genre Sports { get; set; }

        public static Genre SuperHero { get; set; }
        public static Genre Historical { get; set; }
        public static Genre Psychological { get; set; }
        public static Genre Isekai { get; set; }
        public static Genre Shonen { get; set; }
        public static Genre Mecha { get; set; }
        public static Genre Shojo { get; set; }
        public static Genre Seinen { get; set; }
        public static Genre Supernatural { get; set; }






        public static List<Genre> GenerateGenres()
        {
            
            Drama = new Genre
            {
                ID = 1,
                Name = "Drama",
                Description = "Drama series focus on realistic storytelling, often exploring emotional, moral, and social issues."
            };

            Comedy = new Genre
            {
                ID = 2,
                Name = "Comedy",
                Description = "Comedy shows are designed to entertain and make the audience laugh with humorous situations and characters."
            };

            Action = new Genre
            {
                ID = 3,
                Name = "Action",
                Description = "Action series focus on intense physical activity, such as fights, chases, and explosions."
            };

            Adventure = new Genre
            {
                ID = 4,
                Name = "Adventure",
                Description = "Adventure series involve characters embarking on epic journeys, often facing dangers and uncovering secrets."
            };

            Fantasy = new Genre
            {
                ID = 5,
                Name = "Fantasy",
                Description = "Fantasy series feature magical elements, mythical creatures, and worlds beyond the imagination."
            };

            SciFi = new Genre
            {
                ID = 6,
                Name = "Sci-Fi",
                Description = "Science fiction series explore futuristic technologies, space travel, time travel, and other speculative concepts."
            };

            Mystery = new Genre
            {
                ID = 7,
                Name = "Mystery",
                Description = "Mystery series revolve around solving crimes, uncovering secrets, and unraveling complex puzzles."
            };

            Horror = new Genre
            {
                ID = 8,
                Name = "Horror",
                Description = "Horror series focus on fear, suspense, and the supernatural, often involving creepy or disturbing elements."
            };

            Thriller = new Genre
            {
                ID = 9,
                Name = "Thriller",
                Description = "Thriller shows emphasize tension, excitement, and unpredictability, often featuring high-stakes situations."
            };

            Romance = new Genre
            {
                ID = 10,
                Name = "Romance",
                Description = "Romantic series focus on relationships and emotional connections between characters, often with a love story at the heart."
            };

            Crime = new Genre
            {
                ID = 11,
                Name = "Crime",
                Description = "Crime series focus on criminal investigations, law enforcement, and the consequences of illegal activities."
            };

            Documentary = new Genre
            {
                ID = 12,
                Name = "Documentary",
                Description = "Documentary shows provide factual content on a variety of subjects, offering real-life insights and information."
            };

            Anime = new Genre
            {
                ID = 13,
                Name = "Anime",
                Description = "Anime encompasses various genres, typically characterized by vibrant animation, fantastical themes, and Japanese storytelling."
            };

            Sports = new Genre
            {
                ID = 14,
                Name = "Sports",
                Description = "Sports series focus on athletic competition, with a focus on the characters' journeys, triumphs, and setbacks."
            };

           

            SuperHero = new Genre
            {
                ID = 16,
                Name = "Superhero",
                Description = "Superhero shows center on individuals with extraordinary abilities, often featuring battles against villains or threats to humanity."
            };

            Historical = new Genre
            {
                ID = 17,
                Name = "Historical",
                Description = "Historical series are based on real historical events, providing a dramatized or fictionalized account of past occurrences."
            };

            Supernatural = new Genre
            {
                ID = 18,
                Name = "Supernatural",
                Description = "Supernatural series feature elements beyond the natural world, such as ghosts, vampires, and other paranormal occurrences."
            };

            Mecha = new Genre
            {
                ID = 19,
                Name = "Mecha",
                Description = "Mecha series revolve around large robotic suits piloted by humans, often set in futuristic or post-apocalyptic worlds."
            };

            Isekai = new Genre
            {
                ID = 20,
                Name = "Isekai",
                Description = "Isekai anime typically involves characters being transported to, or reincarnated in, a parallel world, often with fantasy elements."
            };

            Shonen = new Genre
            {
                ID = 21,
                Name = "Shonen",
                Description = "Shonen anime primarily targets young male audiences, often featuring action-packed storylines, and coming-of-age themes."
            };

            Shojo = new Genre
            {
                ID = 22,
                Name = "Shojo",
                Description = "Shojo anime primarily targets young female audiences, often featuring romance, friendship, and emotional growth."
            };

            Seinen = new Genre
            {
                ID = 23,
                Name = "Seinen",
                Description = "Seinen anime caters to adult male audiences, with more complex themes, darker tones, and mature content."
            };

           

            Psychological = new Genre
            {
                ID = 25,
                Name = "Psychological",
                Description = "Psychological series focus on mental and emotional conflicts, often exploring themes of perception, manipulation, and mind games."
            };

            
            return new List<Genre>
            {
              Drama, Comedy, Action, Adventure, Fantasy, SciFi, Mystery, Horror,
              Thriller, Romance, Crime, Documentary, Anime, Sports,
              SuperHero, Historical, Supernatural, Mecha, Isekai, Shonen, Shojo,
              Seinen,  Psychological
            };
        }


    }
}
