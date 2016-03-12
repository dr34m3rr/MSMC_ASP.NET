using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace libraV2.Models
{
    public class dbInitializer : DropCreateDatabaseAlways<libraContext>
    {
        protected override void Seed(libraContext db)
        {
            db.Books.Add(new book { name = "Metro 2033", author = "Д. Глуховский", year = new DateTime(2010, 7, 20), description = "Когда‑то давно Московское метро замышлялось как гигантское бомбоубежище, способное спасти десятки тысяч жизней. Мир стоял на пороге гибели, но тогда ее удалось отсрочить. Дорога, по которой идет человечество, вьется, как спираль, и однажды оно снова окажется на краю пропасти. Когда мир будет рушиться, метро окажется последним пристанищем человека перед тем, как он канет в ничто.", pathToImg = "~/Content/img/metro.jpg" });
            for (int i = 0; i < 3; i++)
            {
                db.Books.Add(new book
                {
                    name = "Тот, кто хочет выжить",
                    author = "С. Кинг",
                    year = new DateTime(1995+i, 05, 28),
                    description = "Рано или поздно в процессе обучения у каждого студента-медика возникает вопрос. Какой силы травматический шок может вынести пациент? Разные преподаватели отвечают на этот вопрос по-разному, но, как правило, ответ всегда сводится к новому вопросу: Насколько сильно пациент стремится выжить?",
                    pathToImg = "~/Content/img/king.jpeg"
                });
            }
            db.Books.Add(new book
            {
                name = "Хроники Нарнии",
                author = "Клайв Стейплз Льюис",
                year = new DateTime(2000, 10, 10),
                description = "После начала войны четверо детей из семьи Пэвенси были эвакуированы за город, в дом профессора Кёрка, друга семейства. Пока Питер и Сьюзан, старшие дети, стараются приспособиться к новой обстановке и по возможности заменить родителей, младшие, Эдмунд и Люси, страдают от перемен. Однажды, когда дети играли в прятки, Люси залезла в платяной шкаф и обнаружила, что в глубине его, за шубами, кроется целый волшебный мир.",
                pathToImg = "~/Content/img/narnii.jpeg"
            });

            db.Users.Add(new user
            {
                userName = "Jesus",
                password = "123456", 
                // да я знаю, что нужно делать магию с хешами, нужно бы разобраться, но сейчас 2.55, а мне завтра нужно быть выспавшимся, что бы пить пиво всю ночь, а с утра ещё в школу :((((99
                registrationDate = DateTime.Today,
                birthDay = new DateTime(1995, 05, 28),
                adress = "Vyazemka apparts 169",
                contactInfo = "904 644 15 63",
                isGod = true
            });
            db.Users.Add(new user
            {
                userName = "justUser",
                password = "666",
                registrationDate = DateTime.Today,
                birthDay = new DateTime(2006,06,06),
                adress = "HellStreet",
                contactInfo = "Etis atis animatis… etis atis amatis…",
                isGod = false // kek
            });
            
            base.Seed(db);

        }
        
    }
}