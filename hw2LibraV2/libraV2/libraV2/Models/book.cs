using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace libraV2.Models
{
    public class book
    {
        public int bookID { get; set; }
        public string name { get; set; }
        public string author { get; set; }
        public DateTime year { get; set; }
        public string description { get; set; }
        public string pathToImg { get; set; }
        public virtual ICollection<user> Users { get; set; }
        public book()
        {
            Users = new List<user>();
        }

    }
}