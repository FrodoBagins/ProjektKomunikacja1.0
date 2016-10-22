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

            Functions.createInterface();
        
            Console.SetCursorPosition(13, 13);
            Console.Write("Witam Studenta!");

            ConsoleKeyInfo keypress;
           
            int col = Console.CursorLeft;
            int row = Console.CursorTop;

            int  tempCol,tempRow;
         
            keypress = Console.ReadKey();

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
