using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektKomunikacja
{
    using System;

    public class Baza
    {

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

        public static void Apka3()
        {
            using (var db = new AlarmDbContext())
            {
                var alarm = new Alarm
                {
                    Name = "Pobudka",
                    AlarmTime = DateTime.Now

                };
                db.Alarms.Add(alarm);
                db.SaveChanges();
            }
        }


        public static void Apka4()
        {
            using (var db = new AddressDbContext())
            {
                var address = new Address
                {
                    Company = "McDonald",
                    Town = "Whitestok",
                    Street = "Abbey Road 43",
                    CompPhone = 555666777
                };
                db.Addresses.Add(address);
                db.SaveChanges();
            }
        }


        public static void Apka5()
        {
            using (var db = new NoteDbContext())
            {
                var note = new Note
                {
                    NoteTime = DateTime.Now,
                    Subject = "Lista zakupow",
                    Content = "Mleko, jajka, masło"

                };
                db.Notes.Add(note);
                db.SaveChanges();
            }
        }

    }
}
