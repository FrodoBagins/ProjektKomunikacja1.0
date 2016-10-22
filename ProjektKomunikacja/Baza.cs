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

        public static void AddMeet(DateTime czas,string osoba,string miejsce)
        {
            using (var db = new MeetDbContext())
            {
                var meet = new Meet
                {

                    MeetTime = czas,
                    Place = miejsce,
                    Person = osoba

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

        public static void AddAddress(string compName,string townName,string stName,int compPhon)
        {
            using (var db = new AddressDbContext())
            {
                var address = new Address
                {
                    Company = compName,
                    Town = townName,
                    Street = stName,
                    CompPhone = compPhon
                };
                db.Addresses.Add(address);
                db.SaveChanges();
            }
        }

        public static void AddNote(string temat,string tresc)
        {
            using (var db = new NoteDbContext())
            {
                var note = new Note
                {
                    NoteTime = DateTime.Now,
                    Subject = temat,
                    Content = tresc

                };
                db.Notes.Add(note);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Edycja
        /// </summary>
        /// 



        public static void EditAddress(int id,string compName, string townName, string stName, int compPhon)
        {           
                using (var db = new AddressDbContext())
                {
                    int counter = 1;

                    foreach (var address in db.Addresses)
                    {
                        if (counter == id)
                        {
                         address.Company = compName;
                         address.Town = townName;
                         address.Street = stName;
                         address.CompPhone = compPhon;
                         break;
                        }
                        ++counter;
                    }
                    db.SaveChanges();
                }         
        }


        public static void EditContact(int id,string fName,string lName,int phon,string mail)
        {
            using (var db = new ContactDbContext())
            {
                int counter = 1;

                foreach (var contact in db.Contacts)
                {
                    if (counter == id)
                    {
                       
                        contact.FirstName = fName;
                        contact.LastName = lName;
                        contact.Phone = phon;
                        contact.Mail = mail;

                        break;
                    }
                    ++counter;
                }
                db.SaveChanges();
            }
        }


        public static void EditMeet(int id,DateTime czas, string osoba, string miejsce)
        {
            using (var db = new MeetDbContext())
            {
                 
                int counter = 1;

                foreach (var meet in db.Meetings)
                {
                    if (counter == id)
                    {
                        meet.MeetTime = czas;
                        meet.Person = osoba;
                        meet.Place = miejsce;
                        break;
                    }
                    ++counter;
                }
                db.SaveChanges();
            }
        }



        public static void EditNote(int id,string temat, string tresc)
        {
       
            using (var db = new NoteDbContext())
            {
                int counter = 1;

                foreach (var note in db.Notes)
                {
                    if (counter == id)
                    {

                        Console.WriteLine("Kurwaaaaaaaaaaaaaaaaaaaaaaa");
                        note.NoteTime = DateTime.Now;
                        note.Subject = temat;
                        note.Content = tresc;

                        break;
                    }
                    ++counter;
                }
                db.SaveChanges();
            }

        }




        public static void DeleteContact(int id)
        {
            using (var db = new ContactDbContext())
            {             
                int counter = 1;

                foreach (var contact in db.Contacts)
                {                    
                    if(counter == id)
                    {                        
                        db.Contacts.Remove(contact);
                        break;
                    }                   
                    ++counter;                  
                }
               db.SaveChanges();
            }
        }

        public static void DeleteMeet(int id)
        {
            using (var db = new MeetDbContext())
            {
                int counter = 1;

                foreach (var meet in db.Meetings)
                {
                    if (counter == id)
                    {
                        db.Meetings.Remove(meet);
                        break;
                    }
                    ++counter;
                }
                db.SaveChanges();
            }
        }

        public static void DeleteAddress(int id)
        {
            using (var db = new AddressDbContext())
            {
                int counter = 1;

                foreach (var address in db.Addresses)
                {
                    if (counter == id)
                    {
                        db.Addresses.Remove(address);
                        break;
                    }
                    ++counter;
                }
                db.SaveChanges();
            }
        }

        public static void DeleteNotes(int id)
        {
            using (var db = new NoteDbContext())
            {
                int counter = 1;

                foreach (var note in db.Notes)
                {
                    if (counter == id)
                    {
                        db.Notes.Remove(note);
                        break;
                    }
                    ++counter;
                }
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
