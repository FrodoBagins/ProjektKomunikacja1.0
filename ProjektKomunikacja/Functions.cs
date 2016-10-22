using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektKomunikacja
{
    class Functions
    {

        public static int editNumber;


        public static void addContactInterface()
        {

            Functions.createFrame(30, 7, 80, 22);

            Console.SetCursorPosition(45, 9);
            Console.Write("Dodaj Nowy Kontakt");

            Console.SetCursorPosition(32, 11);
            Console.Write("Podaj Nazwisko:");

            Console.SetCursorPosition(32, 13);
            Console.Write("    Podaj Imie:");

            Console.SetCursorPosition(32, 15);
            Console.Write(" Podaj Nr Tel.:");

            Console.SetCursorPosition(32, 17);
            Console.Write("    Podaj mail:");

            Console.SetCursorPosition(47, 11);
            string nazwisko = Console.ReadLine();

            Console.SetCursorPosition(47, 13);
            string imie = Console.ReadLine();

            Console.SetCursorPosition(47, 15);
            string tel = Console.ReadLine();
            int telefon = Int32.Parse(tel);

            Console.SetCursorPosition(47, 17);
            string mail = Console.ReadLine();

            Console.SetCursorPosition(35, 20);
            Console.WriteLine("[Enter] - Potwierdź    [Esc] - Odrzuć");

            ConsoleKeyInfo key;
            key = Console.ReadKey();

            if (key.Key == ConsoleKey.Enter)
            {
                Baza.AddContact(imie, nazwisko, telefon, mail);
                Functions.createContactInterface();
            }

            if (key.Key == ConsoleKey.Escape)
                Functions.createContactInterface();

        }

        public static void addAddressInterface()
        {
            Functions.createFrame(30, 7, 80, 22);

            Console.SetCursorPosition(45, 9);
            Console.Write("Dodaj Nowy Adres");

            Console.SetCursorPosition(32, 11);
            Console.Write("     Podaj Nazwe:");

            Console.SetCursorPosition(32, 13);
            Console.Write("    Podaj Miasto:");

            Console.SetCursorPosition(32, 15);
            Console.Write("     Podaj Ulice:");

            Console.SetCursorPosition(32, 17);
            Console.Write("   Podaj telefon:");

            Console.SetCursorPosition(49, 11);
            string compName = Console.ReadLine();

            Console.SetCursorPosition(49, 13);
            string townName = Console.ReadLine();

            Console.SetCursorPosition(49, 15);
            string stName = Console.ReadLine();

            Console.SetCursorPosition(49, 17);
            string tel = Console.ReadLine();
            int compPhon = Int32.Parse(tel);



            Console.SetCursorPosition(35, 20);
            Console.WriteLine("[Enter] - Potwierdź    [Esc] - Odrzuć");

            ConsoleKeyInfo key;
            key = Console.ReadKey();

            if (key.Key == ConsoleKey.Enter)
            {
                Baza.AddAddress(compName, townName, stName, compPhon);

                Functions.createAddressInterface();
            }

            if (key.Key == ConsoleKey.Escape)
                Functions.createAddressInterface();

        }

        public static void addMeetInterface(DateTime data)
        {
            Functions.createFrame(30, 4, 80, 22);



            Console.SetCursorPosition(45,6);
            Console.Write("Dodaj Nowe Spotkanie");

            string datash = data.ToShortDateString();


            Console.SetCursorPosition(32, 9);
            Console.Write("         Data:"+datash);


            Console.SetCursorPosition(32, 11);
            Console.Write("      Godzina:");

            Console.SetCursorPosition(32, 13);
            Console.Write("        Minut:");

            Console.SetCursorPosition(32, 15);
            Console.Write("      Miejsce:");

            Console.SetCursorPosition(32, 17);
            Console.Write("        Z kim:");


            Console.SetCursorPosition(46, 11);
            string godzinas = Console.ReadLine();
            int godzina = Int32.Parse(godzinas);

            data = data.AddHours(godzina);

            Console.SetCursorPosition(46, 13);
            string minutas = Console.ReadLine();
            int minuta = Int32.Parse(minutas);

            data = data.AddMinutes(minuta);

            Console.SetCursorPosition(46, 15);
            string miejsce = Console.ReadLine();

            Console.SetCursorPosition(46, 17);
            string osoba = Console.ReadLine();

            Console.SetCursorPosition(35, 20);
            Console.WriteLine("[Enter] - Potwierdź    [Esc] - Odrzuć");

            ConsoleKeyInfo key;
            key = Console.ReadKey();

            if (key.Key == ConsoleKey.Enter)
            {
                Baza.AddMeet(data, osoba, miejsce);
                Functions.createMeetInterface();
            }

            if (key.Key == ConsoleKey.Escape)
                Functions.createMeetInterface();

        }
        
        public static void addNoteInterface(string notatka)
        {
            Functions.createFrame(46, 3, 74, 19);


            Console.SetCursorPosition(50, 6);
            Console.Write(" Dodaj Nową Notatke");

            Console.SetCursorPosition(51, 9);
            Console.WriteLine("  Nazwa notatki:");

            Console.SetCursorPosition(53, 10);
            string temat = Console.ReadLine();

            Console.SetCursorPosition(51, 14);
            Console.WriteLine("[Enter] - Potwierdź");

            Console.SetCursorPosition(51, 16);
            Console.WriteLine("  [Esc] - Odrzuć  ");

            ConsoleKeyInfo key;
            key = Console.ReadKey();

            if (key.Key == ConsoleKey.Enter)
            {

                Baza.AddNote(temat, notatka);
                Functions.createNoteInterface();
            }

            if (key.Key == ConsoleKey.Escape)
                Functions.createNoteInterface();


        }



        public static void editNoteInterface(string tempstring)
        {
            Functions.createFrame(46, 3, 74, 19);


            Console.SetCursorPosition(50, 6);
            Console.Write(" Edytuj Notatke");

            Console.SetCursorPosition(51, 9);
            Console.WriteLine("  Nazwa notatki:");

            Console.SetCursorPosition(53, 10);
            string temat = Console.ReadLine();

            Console.SetCursorPosition(51, 14);
            Console.WriteLine("[Enter] - Potwierdź");

            Console.SetCursorPosition(51, 16);
            Console.WriteLine("  [Esc] - Odrzuć  ");

            ConsoleKeyInfo key;
            key = Console.ReadKey();

            if (key.Key == ConsoleKey.Enter)
            {

                Baza.EditNote(editNumber, temat, tempstring);
                Functions.createNoteInterface();
            }

            if (key.Key == ConsoleKey.Escape)
                Functions.createNoteInterface();


        }

        public static void editContactInterface(int id)
        {
            Functions.createFrame(30, 7, 80, 22);

            Console.SetCursorPosition(45, 9);
            Console.Write("Dodaj Nowy Kontakt");

            Console.SetCursorPosition(32, 11);
            Console.Write(" Nazwisko:");

            Console.SetCursorPosition(32, 13);
            Console.Write("     Imie:");

            Console.SetCursorPosition(32, 15);
            Console.Write("  Nr Tel.:");

            Console.SetCursorPosition(32, 17);
            Console.Write("     Mail:");

            Console.SetCursorPosition(47, 11);
            string nazwisko = Console.ReadLine();

            Console.SetCursorPosition(47, 13);
            string imie = Console.ReadLine();

            Console.SetCursorPosition(47, 15);
            string tel = Console.ReadLine();
            int telefon = Int32.Parse(tel);

            Console.SetCursorPosition(47, 17);
            string mail = Console.ReadLine();

            Console.SetCursorPosition(35, 20);
            Console.WriteLine("[Enter] - Potwierdź    [Esc] - Odrzuć");

            ConsoleKeyInfo key;
            key = Console.ReadKey();

            if (key.Key == ConsoleKey.Enter)
            {
                Baza.EditContact(id, imie, nazwisko, telefon, mail);
                Functions.createContactInterface();
            }

            if (key.Key == ConsoleKey.Escape)
                Functions.createContactInterface();


        }

        public static void editMeetInterface(DateTime data)
        {

            Functions.createFrame(30, 4, 80, 22);

            Console.SetCursorPosition(45, 6);
            Console.Write("Edytuj Spotkanie");

            string datash = data.ToShortDateString();


            Console.SetCursorPosition(32, 9);
            Console.Write("         Data:" + datash);


            Console.SetCursorPosition(32, 11);
            Console.Write("      Godzina:");

            Console.SetCursorPosition(32, 13);
            Console.Write("        Minut:");

            Console.SetCursorPosition(32, 15);
            Console.Write("      Miejsce:");

            Console.SetCursorPosition(32, 17);
            Console.Write("        Z kim:");


            Console.SetCursorPosition(46, 11);
            string godzinas = Console.ReadLine();
            int godzina = Int32.Parse(godzinas);

            data = data.AddHours(godzina);

            Console.SetCursorPosition(46, 13);
            string minutas = Console.ReadLine();
            int minuta = Int32.Parse(minutas);

            data = data.AddMinutes(minuta);

            Console.SetCursorPosition(46, 15);
            string miejsce = Console.ReadLine();

            Console.SetCursorPosition(46, 17);
            string osoba = Console.ReadLine();

            Console.SetCursorPosition(35, 20);
            Console.WriteLine("[Enter] - Potwierdź    [Esc] - Odrzuć");

            ConsoleKeyInfo key;
            key = Console.ReadKey();

            if (key.Key == ConsoleKey.Enter)
            {

                Baza.EditMeet(editNumber, data, osoba, miejsce);
                Functions.createMeetInterface();
            }

            if (key.Key == ConsoleKey.Escape)
                Functions.createMeetInterface();

       }

        public static void editAddressInterface(int id)
        {
            Functions.createFrame(30, 7, 80, 22);

            Console.SetCursorPosition(45, 9);
            Console.Write("Dodaj Nowy Adres");

            Console.SetCursorPosition(32, 11);
            Console.Write("     Podaj Nazwe:");

            Console.SetCursorPosition(32, 13);
            Console.Write("    Podaj Miasto:");

            Console.SetCursorPosition(32, 15);
            Console.Write("     Podaj Ulice:");

            Console.SetCursorPosition(32, 17);
            Console.Write("   Podaj telefon:");

            Console.SetCursorPosition(49, 11);
            string compName = Console.ReadLine();

            Console.SetCursorPosition(49, 13);
            string townName = Console.ReadLine();

            Console.SetCursorPosition(49, 15);
            string stName = Console.ReadLine();

            Console.SetCursorPosition(49, 17);
            string tel = Console.ReadLine();
            int compPhon = Int32.Parse(tel);

            Console.SetCursorPosition(35, 20);
            Console.WriteLine("[Enter] - Potwierdź    [Esc] - Odrzuć");

            ConsoleKeyInfo key;
            key = Console.ReadKey();

            if (key.Key == ConsoleKey.Enter)
            {          
                Baza.EditAddress(id, compName, townName, stName, compPhon);
                Functions.createAddressInterface();
            }

            if (key.Key == ConsoleKey.Escape)
                Functions.createAddressInterface();

        }

        /* 
          Funckje do wypisywania
        */

        public static void createFrame(int minCol,int minRow,int maxCol,int maxRow)
        {
            for (int i = minRow+1; i < maxRow ; ++i)
            {
                Console.SetCursorPosition(minCol, i);
                Console.Write("║");
                Console.SetCursorPosition(maxCol, i);
                Console.Write("║");

            }

            for (int i = minCol+1; i < maxCol; ++i)
            {
                Console.SetCursorPosition(i, minRow);
                Console.Write("═");
                Console.SetCursorPosition(i, maxRow);
                Console.Write("═");
              //  Console.SetCursorPosition(i, 2);
              //  Console.Write("═");
            }

            Console.SetCursorPosition(minCol, minRow);
            Console.Write("╔");
            Console.SetCursorPosition(maxCol, minRow);
            Console.Write("╗");
            Console.SetCursorPosition(minCol, maxRow);
            Console.Write("╚");
            Console.SetCursorPosition(maxCol, maxRow);
            Console.Write("╝");

            for (int i = minCol+1; i < maxCol; i++)
            {
                for (int j = minRow+1; j < maxRow; j++)
                {
                    Console.SetCursorPosition(i, j);
                    Console.Write(" ");
                }

            }



        }


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

            Functions.appMovement(5);
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

            Functions.appMovement(6);
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

            Functions.appMovement(2);
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

            Functions.appMovement(4);
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


               //Delete
                if (keypress.Key == ConsoleKey.Enter && col == 21)
                {
                    int todelete;
                    int numer = Console.CursorTop;

                    todelete = (numer - 2) / 4;

                    if (FuncNumb == 2) { Baza.DeleteContact(todelete); Functions.createContactInterface(); }
                    if (FuncNumb == 3) { Baza.DeleteMeet(todelete);    Functions.createMeetInterface(); }
                    if (FuncNumb == 4) { Baza.DeleteAddress(todelete); Functions.createAddressInterface(); }
                    if (FuncNumb == 6) { Baza.DeleteNotes(todelete); Functions.createNoteInterface(); }
                }


                //Edit
                if (keypress.Key == ConsoleKey.Enter && col == 6)
                {
                    int toedit;
                    int numer = Console.CursorTop;

                    toedit = (numer - 2) / 4;

                    if (FuncNumb == 2) { Functions.editContactInterface(toedit); }
                    if (FuncNumb == 3)
                    {
                        editNumber = toedit;
                        DateTime data = DateTime.Now;
                        new Calendar(data, 4);
                    }
                    if (FuncNumb == 4) { Functions.editAddressInterface(toedit); }
                    if (FuncNumb == 6) { editNumber = toedit; new Notes(DateTime.Now, 2); }

                }




                //Start
                if (keypress.Key == ConsoleKey.F1)
                {                    
                    Functions.createStartInterface();
                }

                //Kontakty
                if (keypress.Key == ConsoleKey.F2)
                {
                    Functions.createContactInterface();
                }

                //Spotkania
                if (keypress.Key == ConsoleKey.F3)
                {
                    Functions.createMeetInterface();

                }

                //Adresy
                if (keypress.Key == ConsoleKey.F4)
                {
                    Functions.createAddressInterface();
                }

                //Alarmy
                if (keypress.Key == ConsoleKey.F5)
                {
                    Functions.createAlarmInterface();
                }

                //Notatki
                if (keypress.Key == ConsoleKey.F6)
                {
                    Functions.createNoteInterface();
                }


                //Add
                if (keypress.Key == ConsoleKey.F7)
                {
                    if (FuncNumb == 2) Functions.addContactInterface();
                    if (FuncNumb == 3)
                    {
                        DateTime data = DateTime.Now;

                        new Calendar(data, 3);

                    }
                    if (FuncNumb == 4) Functions.addAddressInterface();
                    //    if (FuncNumb == 5) Functions.addAlarmInterface();
                    if (FuncNumb == 6) new Notes(DateTime.Now,1);
                }



                keypress = Console.ReadKey();

            }

            Environment.Exit(0);


        }


        public static void createInterface()
        {

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetWindowSize(113, 30);
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

