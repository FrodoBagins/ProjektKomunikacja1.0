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

           Console.SetWindowSize(120,30);
           Console.SetBufferSize(120, 30);


           // for(int i = 0; i <10;i++)

            Console.Beep(800,1000);

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

            }




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

            //    Console.Clear();

            }

         



        }


    }

}
