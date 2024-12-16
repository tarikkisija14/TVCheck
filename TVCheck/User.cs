using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVCheck.Data
{
    public class User
    {
        public int ID {  get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }    
        public string UserName {  get; set; }
        public bool isActive {  get; set; } 
        public string Email {  get; set; }  
        public string Password { get; set; }    
        public DateTime RegistrationDate { get; set; }= DateTime.Now;
        public DateTime LastLoginDate { get; set; }=DateTime.Now;
        public List<Show> Watchlist { get; set; } = new List<Show>();

        public List<Show> ShowsAdded { get; set; } = new List<Show>(); 

        public Image Avatar { get; set; }



        public static User Admin { get; set; }
        public static User NotActive { get; set; }  

        public string IntroduceProfile()
        {
            return $"UserName: {UserName} RegistrationDate: {RegistrationDate} ";
        }
        public override string ToString()
        {
            return IntroduceProfile();
        }
        public static List<User> GenerateUsers()
        {
            Admin = new User
            {
                ID = 1,
                FirstName = "Admin",
                LastName = "Admin",
                UserName = "admin",
                Email = "admin@example.com",
                Password = "admin",
                RegistrationDate = new DateTime(2024, 11, 1),
                isActive = true,
                ShowsAdded = new List<Show>() { Show.BreakingBad, Show.House }
            };
            NotActive = new User
            {
                ID = 2,
                FirstName = "NotActive",
                LastName = "NotActive",
                UserName = "NotActive",
                Email = "NotActive@example.com",
                Password = "notactive",
                RegistrationDate = new DateTime(2023, 11, 1),
                isActive = false,
                ShowsAdded = new List<Show>() { Show.Friends, Show.TheOffice, Show.Sherlock }
            };
            return new List<User> { Admin, NotActive };
        }

    }
}
