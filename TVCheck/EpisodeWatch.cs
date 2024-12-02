using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVCheck.Data
{
    public class EpisodeWatch
    {
        public int ID {  get; set; }    
        public User User { get; set; } 
        public Episode Episode { get; set; } 
        public DateTime WatchDate { get; set; } 
        public string DeviceUsed {  get; set; }
        public string Comments {  get; set; }   



    }
}
