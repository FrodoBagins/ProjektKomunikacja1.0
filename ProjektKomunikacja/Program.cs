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


           // for(int i = 0; i <10;i++)

            Console.Beep(800,1000);

 

            // Console.SetWindowPosition(1,1);

            Console.SetCursorPosition(13, 13);
            Console.Write("Witam Studenta!");
            Console.ReadKey();

            Console.SetCursorPosition(5, 5);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("╔ ╗ ╝ ╚");

            Console.SetCursorPosition(25, 7);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write("ŚćńŁŹżę€ąę~&");
            Console.ReadKey();

        }


    }

}
