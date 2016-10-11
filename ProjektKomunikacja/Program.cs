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

            Console.WriteLine("Hello world!!!");
            Console.ReadLine();

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
