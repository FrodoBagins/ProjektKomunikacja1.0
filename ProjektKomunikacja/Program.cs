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
