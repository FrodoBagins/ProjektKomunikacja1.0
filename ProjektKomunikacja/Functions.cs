using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektKomunikacja
{
    class Functions
    {

        /* 
          Funckje do wypisywania
        */

        public static void printAlarm()
        {
            List<String>Alarms = new List<String>();

            Alarms = Baza.AlarmList();

            int i,j;

            i = Console.CursorLeft;
            j = Console.CursorTop;

            foreach (string baza in Alarms)
            {

                Console.SetCursorPosition(i, j);
                j += 2;

                Console.WriteLine(baza);
                

            }
            
        }


        public static void printContact()
        {
            List<String> Contacts = new List<String>();

            Contacts = Baza.ContactList();

            int i, j;

            i = Console.CursorLeft;
            j = Console.CursorTop;

            foreach (string baza in Contacts)
            {

                Console.SetCursorPosition(i, j);
                j += 2;
                Console.WriteLine(baza);
            }
            
        }


        public static void printMeet()
        {
            List<String> Meetings = new List<String>();

            Meetings = Baza.MeetList();

            int i, j;

            i = Console.CursorLeft;
            j = Console.CursorTop;

            foreach (string baza in Meetings)
            {
                Console.SetCursorPosition(i, j);
                j += 2;
                Console.WriteLine(baza);
            }
            
        }


        public static void printAddress()
        {
            List<String> Addresses = new List<String>();

            Addresses = Baza.AddressList();

            int i, j;

            i = Console.CursorLeft;
            j = Console.CursorTop;

            foreach (string baza in Addresses)
            {

                Console.SetCursorPosition(i, j);
                j += 2;
                Console.WriteLine(baza);
            }
            
        }


        public static void printNotes()
        {
            List<String>Notes = new List<String>();

            Notes = Baza.NoteList();

            int i, j;

            i = Console.CursorLeft;
            j = Console.CursorTop;

            foreach (string baza in Notes)
            {
                Console.SetCursorPosition(i, j);
                j += 2;
                Console.WriteLine(baza);
            }
            

            
        }




        /*
          Fukncja do czyszczenia
        */




        public static void cleaner()
        {
            for (int i = 2; i <= 117; i++)
            {


                for (int j = 3; j <= 28; j++)
                {
                    Console.SetCursorPosition(i, j);
                    Console.Write(" ");
                }

            }
        }




        public static void createMeetInterface()
        {

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(5, 5);

            Functions.printMeet();

          //  DateTime data = new DateTime(2016, 10, 1);

          //  new Calendar(data);


            //   Console.ReadLine();

        }


        public static void createAlarmInterface()
        {

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(5, 5);

            Functions.printAlarm();
          //  Console.ReadLine();

        }

        public static void createNoteInterface()
        {

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(5, 5);

            Functions.printNotes();
            //  Console.ReadLine();

        }


        public static void createContactInterface()
        {

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(5, 5);

            Functions.printContact();
            //  Console.ReadLine();

        }


        public static void createAddressInterface()
        {

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(5, 5);

            Functions.printAddress();
            //  Console.ReadLine();

        }



        public static void menuInterface()
        {

            for(int i = 2; i<118;i++)
            {
                Console.SetCursorPosition(i, 2);
                Console.Write("═");

            }


        }



        public static void createInterface()
        {

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetWindowSize(120, 30);
            Console.SetBufferSize(120, 30);

            Console.SetCursorPosition(1, 0);
            Console.Write("╔");


            Console.SetCursorPosition(1, 29);
            Console.Write("╚");

            Console.SetCursorPosition(118, 0);
            Console.Write("╗");

            Console.SetCursorPosition(118, 29);
            Console.Write("╝");

            for (int i = 1; i < 29; ++i)
            {
                Console.SetCursorPosition(1, i);
                Console.Write("║");
                Console.SetCursorPosition(118, i);
                Console.Write("║");

            }
            for (int i = 2; i < 118; ++i)
            {
                Console.SetCursorPosition(i, 29);
                Console.Write("═");
                Console.SetCursorPosition(i, 0);
                Console.Write("═");
                Console.SetCursorPosition(i, 2);
                Console.Write("═");
            }


            for (int i = 3; i < 100; i += 19)
            {


                Console.SetCursorPosition(i, 0);
                Console.Write("╔");

                Console.SetCursorPosition(i + 16, 0);
                Console.Write("╗");

                Console.SetCursorPosition(i, 1);
                Console.Write("║");

                Console.SetCursorPosition(i + 16, 1);
                Console.Write("║");

                Console.SetCursorPosition(i, 2);
                Console.Write("╩");

                Console.SetCursorPosition(i + 16, 2);
                Console.Write("╩");
            }


            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.SetCursorPosition(4, 1);
            Console.Write("  [F1] Start");

            Console.SetCursorPosition(23, 1);
            Console.Write(" [F2] Kontakty");

            Console.SetCursorPosition(42, 1);
            Console.Write("[F3] Spotkania");

            Console.SetCursorPosition(61, 1);
            Console.Write("  [F4] Adresy");

            Console.SetCursorPosition(80, 1);
            Console.Write(" [F5] Alarmy");

            Console.SetCursorPosition(99, 1);
            Console.Write(" [F6] Notatki");

            Console.ForegroundColor = ConsoleColor.Cyan;


        }
    }
    


    

}

