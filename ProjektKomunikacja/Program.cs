﻿using System;
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

            Functions.createInterface();

            Functions.createFrame(30, 7, 80, 22);

            Console.SetCursorPosition(13, 13);
            Console.Write("Witam Studenta!");


            ConsoleKeyInfo keypress;

            keypress = Console.ReadKey();
           
            int col = Console.CursorLeft;
            int row = Console.CursorTop;

            int  tempCol,tempRow;

          

         //   Console.SetCursorPosition(10, 5);
         //   string nazwa = Console.ReadLine();

         //   Console.SetCursorPosition(10, 6);
         //   Console.WriteLine(nazwa);

         //   keypress = Console.ReadKey();

            while (keypress.Key!= ConsoleKey.F9)
            {

                if(keypress.Key == ConsoleKey.RightArrow )
                {
                    Console.SetCursorPosition(++col, row);
                   
                }

                if (keypress.Key == ConsoleKey.LeftArrow)
                {
                    Console.SetCursorPosition(--col,row);
                    
                }


                if (keypress.Key == ConsoleKey.UpArrow)
                {
                    Console.SetCursorPosition(col, --row);
                  
                }


                if (keypress.Key == ConsoleKey.DownArrow)
                {
                    Console.SetCursorPosition(col, ++row);
                   
                }


                if (keypress.Key == ConsoleKey.Spacebar)
                {
                    Functions.cleaner();
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

                    //    DateTime data = new DateTime(2016, 10, 1);

                    //   new Calendar(data);
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


                tempRow = Console.CursorTop;
                tempCol = Console.CursorLeft;

                Console.SetCursorPosition(93, 27);

                Console.WriteLine("kolumna: " + tempCol + " wiersz: "+tempRow+" ");

                Console.SetCursorPosition(col, row);
     
                keypress = Console.ReadKey();
                        
            }       
        }
    }
}
