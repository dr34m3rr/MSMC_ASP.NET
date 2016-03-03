using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mySite.Models
{
    public class BooksFactory
    {
        public static IEnumerable<book> CreateBooks()
        {
            List<book> books=new List<book>();
            books.Add(new book("PLZ","PLZ","PLZ"));
            books.Add(new book("one", "two", "three"));
            books.Add(new book("name", "author", "desc"));
            books.Add(new book("Сетевая безопасность", "Валерария", "Опыт работы в газпроме"));
            return books;
        }
    }
}