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

        public static void AddContact(string fName,string lName,int phon,string mail)
        {
            using (var db = new ContactDbContext())
            {
                var contact = new Contact
                {
                    FirstName = fName,
                    LastName = lName,
                    Phone = phon,
                    Mail = mail
                };
                db.Contacts.Add(contact);
                db.SaveChanges();
            }
        }

        public static void AddMeet()
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

        public static void AddAlarm()
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


        public static void AddAddress()
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


        public static void AddNote()
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



        public static List<String> MeetList()
        {
            using (var db = new MeetDbContext())
            {
                List<String> Meetings = new List<String>();
                

                foreach (var meet in db.Meetings)
                {
                    string temp, date, time;
                    time = meet.MeetTime.ToShortTimeString();
                    date = meet.MeetTime.ToShortDateString();
                    temp ="Dzien: " + date+" Godzina: "+ time+" Z kim: " + meet.Person + " Gdzie:" + meet.Place;
                    Meetings.Add(temp);

                }
                return Meetings;
            }        
        }




        public static List<String> ContactList()
        {
            using (var db = new ContactDbContext())
            {
                List<String> Contacts = new List<String>();

                int counter=1;

                foreach (var contact in db.Contacts)
                {                  
                    string temp;
                    temp ="Imie: "+ contact.FirstName + " Nazwisko: " + contact.LastName + " Email: " + contact.Mail + " Tel.: " + contact.Phone+" Counter: "+counter;
                    ++counter;
                    Contacts.Add(temp);
                }
                return Contacts;
            }
        }



        public static List<String> AlarmList()
        {
            using (var db = new AlarmDbContext())
            {
                List<String> Alarms = new List<String>();

                foreach (var alarm in db.Alarms)
                {
                    string temp, date,time;
                    time = alarm.AlarmTime.ToShortTimeString();
                    date = alarm.AlarmTime.ToShortDateString();
                    temp = "Nazwa alarmu: " + alarm.Name + " Data: "+date + " Czas: "+time ;
                    Alarms.Add(temp);

                }
                return Alarms;
            }
        }


        public static List<String> AddressList()
        {
            using (var db = new AddressDbContext())
            {
                List<String> Addresses = new List<String>();

                foreach (var address in db.Addresses)
                {
                    string temp;
                    temp ="Nazwa firmy: "+ address.Company + " Miasto: " + address.Town + " Ulica: " + address.Street + " Tel.:" + address.CompPhone;
                    Addresses.Add(temp);
                }
                return Addresses;
            }
        }

        public static List<String> NoteList()
        {
            using (var db = new NoteDbContext())
            {
                List<String> Notes = new List<String>();

                foreach (var note in db.Notes)
                {
                    string temp,date;
                    date = note.NoteTime.ToShortDateString();
                    temp = "Data dodania: "+date + ", " + note.Subject + ": " + note.Content;
                    Notes.Add(temp);
                }
                return Notes;
            }
        }

    }
}
