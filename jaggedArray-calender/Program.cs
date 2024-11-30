using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jaggedArray_calender
{
    public class Calendar
    {
        public static void DisplayCalendar(int month, int year)
        {
            int[] daysInMonth = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (IsLeapYear(year))
                daysInMonth[1] = 29;

            int startDay = GetStartDayOfMonth(month, year);

            int daysInCurrentMonth = daysInMonth[month - 1];
            int weeksInMonth = (daysInCurrentMonth + startDay - 1) / 7 + 1;

            int[][] calendar = new int[weeksInMonth][];

            for (int i = 0; i < weeksInMonth; i++)
            {
                calendar[i] = new int[7];
            }

            int dayCounter = 1;
            for (int week = 0; week < weeksInMonth; week++)
            {
                for (int day = 0; day < 7; day++)
                {
                    if (week == 0 && day < startDay)
                    {
                        calendar[week][day] = 0;
                    }
                    else if (dayCounter <= daysInCurrentMonth)
                    {
                        calendar[week][day] = dayCounter++;
                    }
                    else
                    {
                        calendar[week][day] = 0;
                    }
                }
            }

            Console.WriteLine($"Calendar for {GetMonthName(month)} {year}\n");
            Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");

            for (int i = 0; i < weeksInMonth; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (calendar[i][j] == 0)
                        Console.Write("   ");
                    else
                        Console.Write($"{calendar[i][j],3}");
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        public static int GetStartDayOfMonth(int month, int year)
        {
            DateTime firstDayOfMonth = new DateTime(year, month, 1);
            return (int)firstDayOfMonth.DayOfWeek;
        }

        public static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0));
        }

        public static string GetMonthName(int month)
        {
            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            return months[month - 1];
        }

        public static void Main()
        {
            DisplayCalendar(2, 2024);
        }
    }

}



