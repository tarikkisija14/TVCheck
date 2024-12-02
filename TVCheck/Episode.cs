using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVCheck.Data
{
    public class Episode
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int SeasonNumber {  get; set; }
        public int EpisodeNumber {  get; set; } 
        public string Description { get; set; }
        public TimeSpan Duration { get; set; }
        public DateTime AirDate { get; set; }
        public bool Watched {  get; set; }
        public Show Show { get; set; }
        public Image Avatar { get; set; }

    }
}
