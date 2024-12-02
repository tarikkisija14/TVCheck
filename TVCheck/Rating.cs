using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVCheck.Data
{
    public class Rating
    {
        public int ID {  get; set; }    
        public User User { get; set; }  
        public Show Show { get; set; }
        public int Value {  get; set; } 
        public string Comment {  get; set; }    
        public DateTime RatingDate { get; set; }    
        
    }
}
