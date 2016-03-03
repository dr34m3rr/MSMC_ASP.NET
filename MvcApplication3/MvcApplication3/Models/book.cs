using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mySite.Models
{
    public class book
    {
        public string name;
        public string author;
        public string desc;

        public book(string nm, string ath, string dc)
        {
            this.name = nm;
            this.author = ath;
            this.desc = dc;
        }


    }
}