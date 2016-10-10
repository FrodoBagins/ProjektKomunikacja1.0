using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektKomunikacja
{

    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            Apka2();

            Console.WriteLine("Hello world!!!");
            Console.ReadLine();
        }

        public static void Apka()
        {
            using (var db = new ContactDbContext())
            {
                var contact = new Contact
                {
                    FirstName = "Nadege",
                    LastName = "Deroussen",
                    Phone = 685342542,
                    Mail = "bart@gm.com"
                };
                db.Contacts.Add(contact);
                db.SaveChanges();
            }
        }

        public static void Apka2()
        {
            using (var db = new MeetDbContext())
            {
                var meet = new Meet
                {
                    
                    MeetTime = DateTime.Now,
                    Place = "Palac Zamkowy",
                    Person = "Zbyszko z Bogdanca"


                };
                db.Meetings.Add(meet);
                db.SaveChanges();
            }
        }


    }

}
