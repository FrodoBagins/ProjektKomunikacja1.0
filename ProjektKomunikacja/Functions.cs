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
                Console.WriteLine(baza);
                Console.SetCursorPosition(i, j + 1);
                Console.Write("[ ]-Edytuj     [ ]-Usuń");
                for (int k = i; k < 40; k++)
                {
                    Console.SetCursorPosition(k, j + 2);
                    Console.Write("═");
                }
                j += 4;


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
                Console.WriteLine(baza);
                Console.SetCursorPosition(i, j + 1);
                Console.Write("[ ]-Edytuj     [ ]-Usuń");
                for (int k = i; k < 40; k++)
                {
                    Console.SetCursorPosition(k, j + 2);
                    Console.Write("═");
                }
                j += 4;
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
                Console.WriteLine(baza);
                Console.SetCursorPosition(i, j + 1);
                Console.Write("[ ]-Edytuj     [ ]-Usuń");
                for(int k=i;k<40;k++)
                {
                    Console.SetCursorPosition(k, j + 2);
                    Console.Write("═");
                }
                j += 4;
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
                Console.WriteLine(baza);
                Console.SetCursorPosition(i, j + 1);
                Console.Write("[ ]-Edytuj     [ ]-Usuń");
                for (int k = i; k < 40; k++)
                {
                    Console.SetCursorPosition(k, j + 2);
                    Console.Write("═");
                }
                j += 4;
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
                Console.WriteLine(baza);
                Console.SetCursorPosition(i, j + 1);
                Console.Write("[ ]-Edytuj     [ ]-Usuń");
                for (int k = i; k < 40; k++)
                {
                    Console.SetCursorPosition(k, j + 2);
                    Console.Write("═");
                }
                j += 4;
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

        public static void addButton()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(99, 4);
            Console.Write("[F7]-Dodaj");
    
        }


        public static void createStartInterface()
        {
            Functions.menuInterface();

            Console.SetCursorPosition(3, 2);
            Console.Write("╝");

            Console.SetCursorPosition(19, 2);
            Console.Write("╚");

            for (int i = 4; i < 19; i++)
            {
                Console.SetCursorPosition(i, 2);
                Console.Write(" ");
            }

            Functions.cleaner();




        }


        public static void createMeetInterface()
        {
            //
            Functions.menuInterface();



            Console.SetCursorPosition(41, 2);
            Console.Write("╝");

            Console.SetCursorPosition(57, 2);
            Console.Write("╚");

            for (int i = 42; i < 57; i++)
            {
                Console.SetCursorPosition(i, 2);
                Console.Write(" ");
            }

            Functions.cleaner();
            //

            Functions.addButton();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(5, 5);

            Functions.printMeet();

            Functions.appMovement(3);

            

          //  DateTime data = new DateTime(2016, 10, 1);

          //  new Calendar(data);


            

        }


        public static void createAlarmInterface()
        {
            //
            Functions.menuInterface();

            Console.SetCursorPosition(79, 2);
            Console.Write("╝");

            Console.SetCursorPosition(95, 2);
            Console.Write("╚");

            for (int i = 80; i < 95; i++)
            {
                Console.SetCursorPosition(i, 2);
                Console.Write(" ");
            }

            Functions.cleaner();
            //

            Functions.addButton();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(5, 5);

            Functions.printAlarm();

            Functions.appMovement(3);
        }

        public static void createNoteInterface()
        {
            //
            Functions.menuInterface();

            Console.SetCursorPosition(98, 2);
            Console.Write("╝");

            Console.SetCursorPosition(114, 2);
            Console.Write("╚");

            for (int i = 99; i < 114; i++)
            {
                Console.SetCursorPosition(i, 2);
                Console.Write(" ");

            }

            Functions.cleaner();
//
            

            Functions.addButton();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(5, 5);

            Functions.printNotes();

            Functions.appMovement(3);
        }


        public static void createContactInterface()
        {
            //
            Functions.menuInterface();


            Console.SetCursorPosition(22, 2);
            Console.Write("╝");

            Console.SetCursorPosition(38, 2);
            Console.Write("╚");

            for (int i = 23; i < 38; i++)
            {
                Console.SetCursorPosition(i, 2);
                Console.Write(" ");
            }

            Functions.cleaner();
            //

            Functions.addButton();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(5, 5);

            Functions.printContact();

            Functions.appMovement(3);
        }


        public static void createAddressInterface()
        {
            //
            Functions.menuInterface();

            Console.SetCursorPosition(60, 2);
            Console.Write("╝");

            Console.SetCursorPosition(76, 2);
            Console.Write("╚");

            for (int i = 61; i < 76; i++)
            {
                Console.SetCursorPosition(i, 2);
                Console.Write(" ");
            }


            Functions.cleaner();
            //

            Functions.addButton();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(5, 5);

            Functions.printAddress();

            Functions.appMovement(3);
        }



        public static void menuInterface()
        {

            for(int i = 2; i<118;i++)
            {
                Console.SetCursorPosition(i, 2);
                Console.Write("═");

            }


        }


        public static void appMovement(int FuncNumb)
        {

            ConsoleKeyInfo keypress;
            Console.SetCursorPosition(6, 6);

            int col = 6, row = 6;

            keypress = Console.ReadKey();

            while (keypress.Key != ConsoleKey.F9)
            {

                if (keypress.Key == ConsoleKey.RightArrow && col==6)
                {
                    Console.SetCursorPosition(col+=15, row);

                }

                if (keypress.Key == ConsoleKey.RightArrow && col == 21)
                {
                    Console.SetCursorPosition(col, row);

                }


                if (keypress.Key == ConsoleKey.LeftArrow && col==21)
                {
                    Console.SetCursorPosition(col-=15, row);

                }

                if (keypress.Key == ConsoleKey.LeftArrow && col == 6)
                {
                    Console.SetCursorPosition(col, row);

                }


                if (keypress.Key == ConsoleKey.UpArrow && row!=6)
                {
                    Console.SetCursorPosition(col, row-=4);

                }


                if (keypress.Key == ConsoleKey.UpArrow && row== 6)
                {
                    Console.SetCursorPosition(col, row);

                }



                if (keypress.Key == ConsoleKey.DownArrow)
                {
                    Console.SetCursorPosition(col, row+=4);

                }

                keypress = Console.ReadKey();

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

