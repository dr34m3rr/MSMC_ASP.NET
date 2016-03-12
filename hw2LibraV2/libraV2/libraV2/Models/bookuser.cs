using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace libraV2.Models
{
    public class bookuser
    {
        public int book_bookID { get; set; }
        public int user_userID { get; set; }
        public DateTime whenTook { get; set; }
        public DateTime whenReturn { get; set; }
        public bool isOnHands { get; set; }

        public bookuser(int bookID, int userID)
        {
            this.book_bookID = bookID;
            this.user_userID = userID;
            this.whenTook = DateTime.Today;
            this.whenReturn = whenTook.AddDays(14);
            this.isOnHands = false;
        }
    }
}