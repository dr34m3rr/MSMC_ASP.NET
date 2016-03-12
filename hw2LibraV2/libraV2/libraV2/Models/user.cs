using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace libraV2.Models
{
    public class user
    {
        public int userID { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public DateTime registrationDate { get; set; }
        public DateTime birthDay { get; set; }
        public string adress { get; set; }
        public string contactInfo { get; set; }
        public bool isGod { get; set; }
        public virtual ICollection<book> Books { get; set; }
        public user()
        {
            Books = new List<book>();
        }
    }
}