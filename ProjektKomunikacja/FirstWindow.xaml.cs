using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProjektKomunikacja
{
    /// <summary>
    /// Interaction logic for FirstWindow.xaml
    /// </summary>
    public partial class FirstWindow : Window
    {
        public FirstWindow()
        {
            InitializeComponent();

            List <Contact> contact = new List<Contact>();

            contact = Baza.ContactList2();

            dataGrid.ItemsSource = contact;

            List<Alarm> alarm = new List<Alarm>();

           alarm = Baza.AlarmList2();

            dataGrid2.ItemsSource = alarm;

            List<Meet> meet = new List<Meet>();

            meet = Baza.MeetList2();

            dataGrid3.ItemsSource = meet;

            List<Note> note = new List<Note>();

            note = Baza.NoteList2();

            dataGrid4.ItemsSource = note;

            List<Address> address = new List<Address>();

            address = Baza.AddressList2();

            dataGrid5.ItemsSource = address;

            

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           

        }

        private void ChangeText(object sender, RoutedEventArgs e)
        {
            
        }


        private void add_contact(object sender, RoutedEventArgs e)
        {

            string fname = contact_fName.Text;
            string lname = contact_lName.Text;
            string phonstring = contact_phon.Text;
            int phon = int.Parse(phonstring);
            string mail = contact_mail.Text;

            Baza.AddContact(fname, lname, phon, mail);

            contact_fName.Text = String.Empty;
            contact_lName.Text = String.Empty;
            contact_mail.Text = String.Empty;
            contact_phon.Text = String.Empty;

            label.Content = "Kontakt dodany";

            List<Contact> contact = new List<Contact>();
            contact = Baza.ContactList2();
            dataGrid.ItemsSource = contact;

        }

        private void add_address(object sender, RoutedEventArgs e)
        {
            string comp = address_comp.Text;
            string town = address_town.Text;
            string street = address_street.Text;
            string phonstring = address_phon.Text;
            int phon = int.Parse(phonstring);

            Baza.AddAddress(comp, town, street, phon);

            address_comp.Text = String.Empty;
            address_town.Text = String.Empty;
            address_street.Text = String.Empty;
            address_phon.Text = String.Empty;

            adres_lab.Content = "Adres dodany";

            List<Address> adres = new List<Address>();
            adres = Baza.AddressList2();
            dataGrid5.ItemsSource = adres;

        }

        private void add_meet(object sender, RoutedEventArgs e)
        {
            string hours = meet_h.Text;
            int h = int.Parse(hours);

            string minutes = meet_m.Text;
            int m = int.Parse(minutes);

            string place = meet_place.Text;
            string whom = meet_whom.Text;

            string dat = meet_cal.Text;
            DateTime date = DateTime.Parse(dat);
            date = date.AddHours(h);
            date = date.AddMinutes(m);

            meet.Content = "Spotkanie dodane";

            Baza.AddMeet(date, whom, place);

            meet_cal.Text = String.Empty;
            meet_h.Text = String.Empty;
            meet_m.Text = String.Empty;
            meet_place.Text = String.Empty;
            meet_whom.Text = String.Empty;

            List<Meet> meet2 = new List<Meet>();
            meet2 = Baza.MeetList2();
            dataGrid3.ItemsSource = meet2;

        }

        private void add_alarm(object sender, RoutedEventArgs e)
        {

            // string data = "2016-11-18";
            DateTime date = DateTime.Now;
            string datash = date.ToShortDateString();

            string hours = alarm_h.Text;
            int h = int.Parse(hours);

            string minutes = alarm_m.Text;
            int m = int.Parse(minutes);

            date = DateTime.Parse(datash);

            date = date.AddHours(h);
            date = date.AddMinutes(m);

            string title = alarm_title.Text;

            Baza.AddAlarm(date, title);

            alarm_title.Text = String.Empty;
            alarm_h.Text = String.Empty;
            alarm_m.Text = String.Empty;

            alarm_lab.Content = "Dodano alarm";

            List<Alarm> alarm2 = new List<Alarm>();
            alarm2 = Baza.AlarmList2();
            dataGrid2.ItemsSource = alarm2;


        }

        private void add_note(object sender, RoutedEventArgs e)
        {

            string title = note_sub.Text;
            string body = note_body.Text;

            Baza.AddNote(title, body);

            note_sub.Text = String.Empty;
            note_body.Text = String.Empty;

            note.Content = "Dodano notatkę";

            List<Note> note2 = new List<Note>();
            note2 = Baza.NoteList2();
            dataGrid4.ItemsSource = note2;

        }


        private void Edit_Contact(object sender, RoutedEventArgs e)
        {

            var indexx = dataGrid.Items.IndexOf(dataGrid.CurrentItem);
            int omg = indexx;
           
            string fname = contact_fName.Text;
            string lname = contact_lName.Text;
            string phonstring = contact_phon.Text;
            int phon = int.Parse(phonstring);
            string mail = contact_mail.Text;

            Baza.EditContact(omg + 1, fname, lname, phon, mail);

            contact_fName.Text = String.Empty;
            contact_lName.Text = String.Empty;
            contact_mail.Text = String.Empty;
            contact_phon.Text = String.Empty;
            label.Content = "Kontakt zmieniony";

            List<Contact> contact = new List<Contact>();
            contact = Baza.ContactList2();
            dataGrid.ItemsSource = contact;

        }

        private void Edit_Address(object sender, RoutedEventArgs e)
        {
            var indexx = dataGrid5.Items.IndexOf(dataGrid5.CurrentItem);
            int omg = indexx;


            string comp = address_comp.Text;
            string town = address_town.Text;
            string street = address_street.Text;
            string phonstring = address_phon.Text;
            int phon = int.Parse(phonstring);

            Baza.EditAddress(omg + 1, comp, town, street, phon);

            address_comp.Text = String.Empty;
            address_town.Text = String.Empty;
            address_street.Text = String.Empty;
            address_phon.Text = String.Empty;

            adres_lab.Content = "Adres zmieniony";

            List<Address> adres = new List<Address>();
            adres = Baza.AddressList2();
            dataGrid5.ItemsSource = adres;

        }

        private void Edit_Meet(object sender, RoutedEventArgs e)
        {
            var indexx = dataGrid3.Items.IndexOf(dataGrid3.CurrentItem);
            int omg = indexx;
            meet.Content = " " + omg;

            string hours = meet_h.Text;
            int h = int.Parse(hours);
            string minutes = meet_m.Text;
            int m = int.Parse(minutes);
            string place = meet_place.Text;
            string whom = meet_whom.Text;
            string dat = meet_cal.Text;
            DateTime date = DateTime.Parse(dat);
            date = date.AddHours(h);
            date = date.AddMinutes(m);

           
            Baza.EditMeet(omg + 1, date, whom, place);

            meet_cal.Text = String.Empty;
            meet_h.Text = String.Empty;
            meet_m.Text = String.Empty;
            meet_place.Text = String.Empty;
            meet_whom.Text = String.Empty;

            meet.Content = "Spotkanie zmienione";

            List<Meet> meet2 = new List<Meet>();
            meet2 = Baza.MeetList2();
            dataGrid3.ItemsSource = meet2;

        }

        private void Edit_Alarm(object sender, RoutedEventArgs e)
        {
            var indexx = dataGrid2.Items.IndexOf(dataGrid2.CurrentItem);
            int omg = indexx;

            Baza.SetAlarm(omg + 1);

            alarm_title.Text = String.Empty;
            alarm_h.Text = String.Empty;
            alarm_m.Text = String.Empty;

            alarm_lab.Content = "Ustawiono alarm";

        }

        private void Edit_Note(object sender, RoutedEventArgs e)
        {
            var indexx = dataGrid4.Items.IndexOf(dataGrid4.CurrentItem);
            int omg = indexx;

            string title = note_sub.Text;
            string body = note_body.Text;

            Baza.EditNote(omg + 1, title, body);

            note_sub.Text = String.Empty;
            note_body.Text = String.Empty;

            note.Content = "Zmieniono notatkę";

            List<Note> note2 = new List<Note>();
            note2 = Baza.NoteList2();
            dataGrid4.ItemsSource = note2;

        }


        public void Delete_Contact(object sender, RoutedEventArgs e)
        {

            var indexx = dataGrid.Items.IndexOf(dataGrid.CurrentItem);
            int omg = indexx;
            label.Content = " " + omg;
            Baza.DeleteContact(omg + 1);
            List<Contact> contact = new List<Contact>();
            contact = Baza.ContactList2();
            dataGrid.ItemsSource = contact;
            label.Content = "Kontakt usunięty";

        }

        private void Delete_Address(object sender, RoutedEventArgs e)
        {
            var indexx = dataGrid5.Items.IndexOf(dataGrid5.CurrentItem);
            int omg = indexx;

            Baza.DeleteAddress(omg + 1);

            adres_lab.Content = "Usunięto adres";

            List<Address> adres = new List<Address>();
            adres = Baza.AddressList2();
            dataGrid5.ItemsSource = adres;

        }

        private void Delete_Meet(object sender, RoutedEventArgs e)
        {
            var indexx = dataGrid3.Items.IndexOf(dataGrid3.CurrentItem);
            int omg = indexx;
            
            Baza.DeleteMeet(omg + 1);

            List<Meet> meet2 = new List<Meet>();
            meet2 = Baza.MeetList2();
            dataGrid3.ItemsSource = meet2;
            meet.Content = "Spotkanie usunięte";

        }

        private void Delete_Alarm(object sender, RoutedEventArgs e)
        {
            var indexx = dataGrid2.Items.IndexOf(dataGrid2.CurrentItem);
            int omg = indexx;

            Baza.DeleteAlarms(omg + 1);

            alarm_lab.Content = "Usunięto alarm";

            List<Alarm> alarm2 = new List<Alarm>();
            alarm2 = Baza.AlarmList2();
            dataGrid2.ItemsSource = alarm2;

        }

        private void Delete_Note(object sender, RoutedEventArgs e)
        {
            var indexx = dataGrid4.Items.IndexOf(dataGrid4.CurrentItem);
            int omg = indexx;

            Baza.DeleteNotes(omg + 1);

            note.Content = "Usunięto notatkę";

            List<Note> note2 = new List<Note>();
            note2 = Baza.NoteList2();
            dataGrid4.ItemsSource = note2;

        }


        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {




        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
