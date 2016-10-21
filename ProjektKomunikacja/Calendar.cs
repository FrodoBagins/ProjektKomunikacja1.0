using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Calendar
    {
        private static int lr = (Console.WindowWidth / 2) - 14;
        private static int[] tab = new int[] { lr + 2, lr + 6, lr + 10, lr + 14, lr + 18, lr + 22, lr + 26 };
        private static int buffPos = 0;
        private static bool isMonth = true;

        public Calendar() { }

        public Calendar(DateTime date)
        {
            Console.SetCursorPosition(0, 0);
            Console.CursorVisible = false;
            int mthcounter = 10, yrcounter = 2016;
            int dayCounter = 1; //zmienna, czy doszło do przejścia z miesięcy na dnie
            int day = 1; //którym dniem tygodnia zaczyna się mieisąc, iteracja po dniach
            int j = 9; //do przechodzenia w dół tygodnia
            DateTime data = date;
            drawRectangle(data);
            ConsoleKeyInfo keyInfo;
            string month = convertMonth(data.Month);
            Console.SetCursorPosition((Console.WindowWidth / 2) - (month.Length) / 2, 2);
            keyInfo = Console.ReadKey(true);
            while (true)
            {
                if (keyInfo.Key == ConsoleKey.RightArrow && isMonth == true) /*przewijanie miesięcy*/
                {
                    mthcounter++;
                    if (mthcounter > 12)
                    {
                        mthcounter = 1;
                        yrcounter++;
                    }
                    data = new DateTime(yrcounter, mthcounter, 1);
                    drawRectangle(data);
                }
                else if (keyInfo.Key == ConsoleKey.LeftArrow && isMonth == true) /*przewijanie miesięcy*/
                {
                    mthcounter--;
                    if (mthcounter < 1)
                    {
                        mthcounter = 12;
                        yrcounter--;
                    }
                    data = new DateTime(yrcounter, mthcounter, 1);
                    drawRectangle(data);
                }
                else if (keyInfo.Key == ConsoleKey.DownArrow && isMonth == true) /*przejście miesiąc-dni miesiąca*/
                {
                    dayCounter = 1;
                    j = 9;
                    DayOfWeek dayOfWeek = data.DayOfWeek;
                    day = hashDayOfWeek(dayOfWeek);
                    isMonth = false;
                    drawRectangle(data);
                    Console.SetCursorPosition(tab[day], 9);
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("1");
                }
                else if (keyInfo.Key == ConsoleKey.UpArrow && isMonth == false && j == 9) /*przejsćie dni miesiąca - miesiące*/
                {
                    j = 5;
                    isMonth = true;
                    drawRectangle(data);
                }
                else if (keyInfo.Key == ConsoleKey.LeftArrow) /*przechodzenie po dniach miesiąca*/
                {
                    int daysInMonth = DateTime.DaysInMonth(data.Year, data.Month);
                    isMonth = false;
                    day--;
                    if (day < 0)
                    {
                        day = 6;
                        j = j - 2;
                    }
                    drawRectangle(data);
                    dayCounter--;
                    if (dayCounter < 1)
                    {
                        break;
                        //ULEPSZYĆ!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                    }
                    Console.SetCursorPosition(tab[day], j);
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(dayCounter);
                }
                else if (keyInfo.Key == ConsoleKey.RightArrow) /*przechodzenie po dniach miesiąca*/
                {
                    int daysInMonth = DateTime.DaysInMonth(data.Year, data.Month);
                    isMonth = false;
                    day++;
                    if (day == 7)
                    {
                        day = 0;
                        j = j + 2;
                    }
                    drawRectangle(data);
                    dayCounter++;
                    if (dayCounter > daysInMonth)
                    {
                        break; // ULEPSZYĆ!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                    }
                    Console.SetCursorPosition(tab[day], j);
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(dayCounter);
                }
                else if (keyInfo.Key == ConsoleKey.DownArrow) /*przechodzenie po dniach miesiąca*/
                {
                    // ZROBIĆ WYJĄTEK, KIEDY NIE MA POD SPODEM JUŻ ŻADNEJ LICZBY!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                    dayCounter = dayCounter + 7;
                    isMonth = false;
                    j = j + 2;
                    drawRectangle(data);
                    Console.SetCursorPosition(tab[day], j);
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(dayCounter);
                }
                else if (keyInfo.Key == ConsoleKey.UpArrow) /*przechodzenie po dniach miesiąca*/
                {
                    //ZROBIĆ WYJĄTEK, KIEDY NAD LICZBĄ NIE MA JUŻ ŻADNEJ LICZBY!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                    dayCounter = dayCounter - 7;
                    isMonth = false;
                    j = j - 2;
                    drawRectangle(data);
                    Console.SetCursorPosition(tab[day], j);
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(dayCounter);
                }
                else if (keyInfo.Key == ConsoleKey.Escape)
                {
                    break;
                }
                else if (keyInfo.Key == ConsoleKey.Enter)
                {
                    Console.SetCursorPosition(1, 20);
                    Console.WriteLine(dayCounter);
                    //new Note(new DateTime(yrcounter, mthcounter, dayCounter));
                }
                else /*nie wiem, co tu zrobić :( */
                {

                }
                keyInfo = Console.ReadKey(true);
            }
        }

        public static void drawRectangle(DateTime data)
        {
            Console.ResetColor();
            Console.CursorVisible = false;
            int rightRange = (Console.WindowWidth) / 2 + 15;
            int leftRange = (Console.WindowWidth) / 2 - 14;
            DateTime date = new DateTime(data.Year, data.Month, data.Day);
            int daysInMonth = DateTime.DaysInMonth(date.Year, date.Month);
            string month = convertMonth(date.Month);
            Console.SetCursorPosition(leftRange, 1 + 3);
            Console.Write("╔═══════════════════════════╗"); /*ramka - początek*/
            for (int i = 5; i < 20; i++)
            {
                if (i % 2 == 0 && i != 6) /*ramka między dniami*/
                {
                    Console.SetCursorPosition(leftRange, i);
                    Console.Write("╠═══╬═══╬═══╬═══╬═══╬═══╬═══╣");
                }
                else if (i % 2 == 1 && i != 5 && i != 7 && i != 9) /*tabele z dniami - inicjalizacja*/
                {
                    Console.SetCursorPosition(leftRange, i);
                    Console.Write("║   ║   ║   ║   ║   ║   ║   ║");
                }
                else if (i == 6) /*ramka między miesiącem, a dniami tygodnia*/
                {
                    Console.SetCursorPosition(leftRange, i);
                    Console.Write("╠═══╦═══╦═══╦═══╦═══╦═══╦═══╣");
                }
                else if (i == 7) /*tabela z dniami tygodnia*/
                {
                    Console.SetCursorPosition(leftRange, i);
                    Console.Write("║Pon║Wto║Śro║Czw║Pią║Sob║Nie║");
                }
                else if (i == 9) /*tabele z dniami*/
                {
                    Console.SetCursorPosition(leftRange, i);
                    Console.Write("║   ║   ║   ║   ║   ║   ║   ║");
                    switch (date.DayOfWeek)
                    {
                        case DayOfWeek.Monday:
                            Console.SetCursorPosition(leftRange + 2, i);
                            buffPos = 0;
                            break;
                        case DayOfWeek.Tuesday:
                            Console.SetCursorPosition(leftRange + 6, i);
                            buffPos = 1;
                            break;
                        case DayOfWeek.Wednesday:
                            Console.SetCursorPosition(leftRange + 10, i);
                            buffPos = 2;
                            break;
                        case DayOfWeek.Thursday:
                            Console.SetCursorPosition(leftRange + 14, i);
                            buffPos = 3;
                            break;
                        case DayOfWeek.Friday:
                            Console.SetCursorPosition(leftRange + 18, i);
                            buffPos = 4;
                            break;
                        case DayOfWeek.Saturday:
                            Console.SetCursorPosition(leftRange + 22, i);
                            buffPos = 5;
                            break;
                        case DayOfWeek.Sunday:
                            Console.SetCursorPosition(leftRange + 26, i);
                            buffPos = 6;
                            break;
                    }
                }
                else /*i == 2+3 - tabela z miesiącem*/
                {
                    Console.SetCursorPosition(leftRange, i);
                    Console.Write("║                           ║");
                    Console.SetCursorPosition(leftRange + 1, i);
                    Console.SetCursorPosition((Console.WindowWidth) / 2 - (month.Length / 2), i);
                    if (isMonth == true)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write(month);
                        Console.ResetColor();
                    }
                    else Console.Write(month);
                    Console.SetCursorPosition(rightRange - 5, i);
                    Console.Write(date.Year);
                }
            }
            Console.SetCursorPosition(leftRange, 20);
            Console.Write("╚═══╩═══╩═══╩═══╩═══╩═══╩═══╝"); /*ramka - koniec*/
            writeDays(buffPos, daysInMonth);
        }

        private static string convertMonth(int month)
        {
            switch (month)
            {
                case 1:
                    return "STYCZEŃ";
                case 2:
                    return "LUTY";
                case 3:
                    return "MARZEC";
                case 4:
                    return "KWIECIEŃ";
                case 5:
                    return "MAJ";
                case 6:
                    return "CZERWIEC";
                case 7:
                    return "LIPIEC";
                case 8:
                    return "SIERPIEŃ";
                case 9:
                    return "WRZESIEŃ";
                case 10:
                    return "PAŹDZIERNIK";
                case 11:
                    return "LISTOPAD";
                default:
                    return "GRUDZIEŃ";
            }
        }

        private static void writeDays(int start, int monthLength)
        {
            int j = 6 + 3;

            Console.SetCursorPosition(tab[start], j);
            for (int i = 1; i <= monthLength; i++)
            {
                Console.Write(i);
                start++;
                if (start >= 7)
                {
                    start = 0;
                    j = j + 2;
                }
                Console.SetCursorPosition(tab[start], j);
            }
        }

        public static int hashDayOfWeek(DayOfWeek day)
        {
            switch (day)
            {
                case DayOfWeek.Monday:
                    return 0;
                case DayOfWeek.Tuesday:
                    return 1;
                case DayOfWeek.Wednesday:
                    return 2;
                case DayOfWeek.Thursday:
                    return 3;
                case DayOfWeek.Friday:
                    return 4;
                case DayOfWeek.Saturday:
                    return 5;
                case DayOfWeek.Sunday:
                    return 6;
            }
            return 0;
        }
    }
}