using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektKomunikacja
{
    class Functions
    {

        public static void drukuj()
        {
            List<String> Meetings = new List<String>();

            Meetings = Baza.AlarmList();

            foreach (string baza in Meetings)
            {
                Console.WriteLine(baza);
            }
            Console.ReadLine();

        }






    }
}
