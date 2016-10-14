using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektKomunikacja
{
    class Functions
    {

        public static void drukuj()
        {
            List<String> Meetings = new List<String>();

            Meetings = Baza.AlarmList();

            foreach (string baza in Meetings)
            {
                Console.WriteLine(baza);
            }
            Console.ReadLine();
        }



   /*     public static void cleaner()
        {
            for(int i =2;i<=117;i++)
            {


                for(int j=2;i<=1117)



            }

    */
            





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


            for (int i = 3; i < 100; i+=16)
            {
                

                Console.SetCursorPosition(i, 0);
                Console.Write("╔");

                Console.SetCursorPosition(i+13, 0);
                Console.Write("╗");

                Console.SetCursorPosition(i, 1);
                Console.Write("║");

                Console.SetCursorPosition(i+13, 1);
                Console.Write("║");

                Console.SetCursorPosition(i, 2);
                Console.Write("╩");

                Console.SetCursorPosition(i+13, 2);
                Console.Write("╩");
            }
        }
    }
}
