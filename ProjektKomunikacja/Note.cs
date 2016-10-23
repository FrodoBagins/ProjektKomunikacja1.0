using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektKomunikacja
{
    class Notes
    {
        public Notes() { }

        public Notes(DateTime date,int type)
        {
            int leftRange = (Console.WindowWidth) / 2 - 14;
            int rightRange = (Console.WindowWidth) / 2 + 15;
            ConsoleKeyInfo keyInfo;
            char[] notatka = new char[350];
            int buffCounter = 0;
            int cursPos = 1;
            int j = 6;
            int licznik = 0;

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(leftRange, 4);
            for (int i = 3; i < 20; i++)
            {
                Console.SetCursorPosition(leftRange, i);
                if (i == 3) Console.Write("╔═══════════════════════════╗");
                else if (i == 4) Console.Write("║          NOTATKA          ║");
                else if (i == 5) Console.Write("╠═══════════════════════════╣");
                else if (i == 6) Console.Write("║Napisz coś...              ║");
                else if (i == 19) Console.Write("╚═══════════════════════════╝");
                else Console.Write("║                           ║");
            }
            Console.SetCursorPosition(leftRange + 1, j);
            keyInfo = Console.ReadKey(true);
            Console.CursorVisible = false;
            Console.SetCursorPosition(leftRange, j);
            Console.Write("║" + keyInfo.KeyChar + "                          ║");
            Console.SetCursorPosition(leftRange + 2, j);

            while (keyInfo.Key != ConsoleKey.Enter)
            {
                cursPos++;
                if (licznik == 1)
                {
                    cursPos--;
                    Console.SetCursorPosition(leftRange, j);
                    Console.Write("║" + keyInfo.KeyChar + "                          ║");
                    Console.SetCursorPosition(leftRange + 2, j);
                    licznik = 0;
                }
                if (Console.CursorLeft == rightRange - 1 || Console.CursorLeft == rightRange)
                {
                    Console.SetCursorPosition(leftRange + 1, ++j);
                    cursPos = 1;
                }
                else if (keyInfo.Key == ConsoleKey.Backspace)
                {
                    if (Console.CursorLeft == leftRange + 1 && Console.CursorTop == 6)
                    {
                        Console.Write(" ");
                        cursPos--;
                        buffCounter = 0;
                        licznik++;
                        Console.Write("Napisz coś...             ║");
                        Console.SetCursorPosition(leftRange + 1, 6);
                    }

                    else if (Console.CursorLeft == leftRange + 1)
                    {
                        Console.Write(" ");
                        cursPos--;
                        Console.SetCursorPosition(rightRange - 1, --j);
                        cursPos = 28;
                    }
                    else
                    {
                        Console.Write(" ");
                        cursPos--;
                        cursPos--;
                        Console.SetCursorPosition(leftRange + cursPos, j);
                    }
                }
                else
                {
                    notatka[buffCounter] = keyInfo.KeyChar;
                    buffCounter++;
                }

                keyInfo = Console.ReadKey();
            }


    
            string tempstring = new string(notatka);

            Console.CursorVisible = true;

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Cyan;


            if(type == 1)
             Functions.addNoteInterface(tempstring);

            if (type == 2)
                Functions.editNoteInterface(tempstring);



            //  Console.ReadKey();
        }
    }
}