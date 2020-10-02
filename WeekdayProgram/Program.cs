using static WeekdayLibrary.Weekday;
using System;

namespace WeekdayProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task #02. Weekday\n");
            Console.WriteLine("Answer: " + ShowWeekday(GetNumber("Enter number weekday (1-7): ")));
        }
    }
}