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

            //  Console.WindowHeight();

            Functions.createInterface();

            Functions.cleaner();


            // Console.SetWindowPosition(1,1);

            Console.SetCursorPosition(13, 13);
            Console.Write("Witam Studenta!");
           // Console.ReadKey();

           // Console.SetCursorPosition(5, 5);
            //Console.ForegroundColor = ConsoleColor.Blue;
           // Console.Write("╔ ╗ ╝ ╚");

           // Console.SetCursorPosition(25, 7);
           // Console.ForegroundColor = ConsoleColor.Cyan;
           // Console.BackgroundColor = ConsoleColor.DarkBlue;
          //  Console.Write("ŚćńŁŹżę€ąę~&");
            
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
                   // Console.Beep(800, 200);
                }

                if (keypress.Key == ConsoleKey.LeftArrow)
                {
                    Console.SetCursorPosition(--col,row);
                    //Console.Beep(800, 200);
                }


                if (keypress.Key == ConsoleKey.UpArrow)
                {
                    Console.SetCursorPosition(col, --row);
                  //  Console.Beep(800, 200);
                }


                if (keypress.Key == ConsoleKey.DownArrow)
                {
                    Console.SetCursorPosition(col, ++row);
                   // Console.Beep(800, 200);
                }


                if (keypress.Key == ConsoleKey.Spacebar)
                {
                    Functions.cleaner();
                }



                if (keypress.Key == ConsoleKey.F1)
                {
                    Functions.createInterface();


                    Console.SetCursorPosition(3, 2);
                    Console.Write("╝");

                    Console.SetCursorPosition(19, 2);
                    Console.Write("╚");

                    for(int i=4;i<19;i++)
                    {
                        Console.SetCursorPosition(i, 2);
                        Console.Write(" ");
                    }
                }

                if (keypress.Key == ConsoleKey.F2)
                {
                    Functions.createInterface();

                    Functions.createContactInterface();


                    Console.SetCursorPosition(22, 2);
                    Console.Write("╝");

                    Console.SetCursorPosition(38, 2);
                    Console.Write("╚");

                    for (int i = 23; i <38; i++)
                    {
                        Console.SetCursorPosition(i, 2);
                        Console.Write(" ");
                    }
                }


                if (keypress.Key == ConsoleKey.F3)
                {
                    Functions.createInterface();

                    Functions.cleaner();

                    Functions.createKalendarzInterface();

                    Console.SetCursorPosition(41, 2);
                    Console.Write("╝");

                    Console.SetCursorPosition(57, 2);
                    Console.Write("╚");

                    for (int i = 42; i < 57; i++)
                    {
                        Console.SetCursorPosition(i, 2);
                        Console.Write(" ");
                    }

                //    DateTime data = new DateTime(2016, 10, 1);

                 //   new Calendar(data);

                        

                }

                if (keypress.Key == ConsoleKey.F4)
                {
                    Functions.createInterface();

                    Console.SetCursorPosition(60, 2);
                    Console.Write("╝");

                    Console.SetCursorPosition(76, 2);
                    Console.Write("╚");

                    for (int i = 61; i < 76; i++)
                    {
                        Console.SetCursorPosition(i, 2);
                        Console.Write(" ");
                    }
                }


                if (keypress.Key == ConsoleKey.F5)
                {
                    Functions.createInterface();

                    Functions.cleaner();

                    Functions.createAlarmInterface();

                    Console.SetCursorPosition(79, 2);
                    Console.Write("╝");

                    Console.SetCursorPosition(95, 2);
                    Console.Write("╚");

                    for (int i = 80; i < 95; i++)
                    {
                        Console.SetCursorPosition(i, 2);
                        Console.Write(" ");
                    }
                }


                if (keypress.Key == ConsoleKey.F6)
                {
                    Functions.createInterface();

                    Console.SetCursorPosition(98, 2);
                    Console.Write("╝");

                    Console.SetCursorPosition(114, 2);
                    Console.Write("╚");

                    for (int i = 99; i < 114; i++)
                    {
                        Console.SetCursorPosition(i, 2);
                        Console.Write(" ");
                    }
                }


                tempRow = Console.CursorTop;
                tempCol = Console.CursorLeft;


                Console.SetCursorPosition(4, 4);

                Console.WriteLine("kolumna: " + tempCol + "wiersz: "+tempRow);

                Console.SetCursorPosition(col, row);

                
                keypress = Console.ReadKey();

         

            }

         



        }


    }

}
