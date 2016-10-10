using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektKomunikacja
{
    using System.Data.Entity;

    // Kontakty 
    public class ContactDbContext : DbContext
    {
        public ContactDbContext() : base("name=DataModelContext")
        {

        }
        public DbSet<Contact> Contacts { get; set; }
    }

    // Spotkania
    public class MeetDbContext : DbContext
    {
        public MeetDbContext() : base("name=DataModelContext")
        {

        }
        public DbSet<Meet> Meetings { get; set; }
    }

    // Alarmy
    public class AlarmDbContext : DbContext
    {
        public AlarmDbContext() : base("name=DataModelContext")
        {

        }
        public DbSet<Alarm> Alarms { get; set; }
    }

    // Adresy
    public class AddressDbContext : DbContext
    {
        public AddressDbContext() : base("name=DataModelContext")
        {

        }
        public DbSet<Address> Addresses { get; set; }
    }

    // Notatki
    public class NoteDbContext : DbContext
    {
        public NoteDbContext() : base("name=DataModelContext")
        {

        }
        public DbSet<Note> Notes { get; set; }
    }


}
