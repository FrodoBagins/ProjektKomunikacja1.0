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

            keypress = Console.ReadKey();

           
            int col = Console.CursorLeft;
            int row = Console.CursorTop;

            int  tempCol,tempRow;







            while(keypress.Key!= ConsoleKey.F9)
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
                    

                    Functions.menuInterface();

                    Console.SetCursorPosition(3, 2);
                    Console.Write("╝");

                    Console.SetCursorPosition(19, 2);
                    Console.Write("╚");

                    for(int i=4;i<19;i++)
                    {
                        Console.SetCursorPosition(i, 2);
                        Console.Write(" ");
                    }

                    Functions.cleaner();
                    // Functions.createStartInterface();
                }


                //Kontakty
                if (keypress.Key == ConsoleKey.F2)
                {
       

                    Functions.menuInterface();
                   

                    Console.SetCursorPosition(22, 2);
                    Console.Write("╝");

                    Console.SetCursorPosition(38, 2);
                    Console.Write("╚");

                    for (int i = 23; i <38; i++)
                    {
                        Console.SetCursorPosition(i, 2);
                        Console.Write(" ");
                    }

                    Functions.cleaner();

                    Functions.createContactInterface();


                }


                //Spotkania
                if (keypress.Key == ConsoleKey.F3)
                {
                    
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

                    Functions.createMeetInterface();

                    //    DateTime data = new DateTime(2016, 10, 1);

                    //   new Calendar(data);



                }



                //Adresy
                if (keypress.Key == ConsoleKey.F4)
                {
                    
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
                    Functions.createAddressInterface();
                }



                //Alarmy
                if (keypress.Key == ConsoleKey.F5)
                {

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

                    Functions.createAlarmInterface();


                }


                //Notatki
                if (keypress.Key == ConsoleKey.F6)
                {                   

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
