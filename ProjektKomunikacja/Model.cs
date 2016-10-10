using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektKomunikacja
{
    using System;

    /// <summary>
    /// Kontakty
    /// </summary>
    public class Contact
    {
       
        public int ContactId { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public int Phone { get; set; }

        public string Mail { get; set; }

    }


    /// <summary>
    /// Spotkania
    /// </summary>
    public class Meet
    {
        public int MeetId { get; set; }

        public DateTime MeetTime { get; set; }

        public string Place { get; set; }

        public string Person { get; set; }

    }

    /// <summary>
    /// Alarmy
    /// </summary>
    public class Alarm
    {
        public int AlarmId { get; set; }

        public string Name { get; set; }

        public DateTime AlarmTime { get; set; }

    }

    /// <summary>
    /// Adresy
    /// </summary>
    public class Address
    {
        public int AddressId { get; set; }

        public string Company { get; set; }

        public string Town { get; set; }

        public string Street { get; set; }

        public int CompPhone { get; set; }

    }

    /// <summary>
    /// Notatki
    /// </summary>
    public class Note
    {
        public int NoteId { get; set; }

        public DateTime NoteTime { get; set; }

        public string Subject { get; set; }

        public string Content { get; set; }

    }


}
