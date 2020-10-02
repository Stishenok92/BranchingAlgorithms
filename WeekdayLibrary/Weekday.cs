using System;

namespace WeekdayLibrary
{
    public class Weekday
    {
        public const string MSG_FORMAT_EXCEPTION = "Error: input data is incorrect!";
        public const string MSG_INCORRECT_NUMBER_WEEK = "Sorry, no such day of the week!";
        
        private static string GetString(string msg)
        {
            Console.Write(msg);
            return Console.ReadLine();
        }

        public static int ToInt(string str)
        {
            try
            {
                return int.Parse(str);
            }
            catch (FormatException)
            {
                Console.WriteLine(MSG_FORMAT_EXCEPTION);
                return 0;
            }
        }

        public static int GetNumber(string msg)
        {
            return ToInt(GetString(msg));
        }
        
        public static string ShowWeekday(int numberWeekday)
        {
            string msg;
            
            switch (numberWeekday)
            {
                case 1: msg = "Monday"; break;
                case 2: msg = "Tuesday"; break;
                case 3: msg = "Wednesday"; break;
                case 4: msg = "Thursday"; break;
                case 5: msg = "Friday"; break;
                case 6: msg = "Saturday"; break;
                case 7: msg = "Sunday"; break;
                default: msg = MSG_INCORRECT_NUMBER_WEEK; break;
            }

            return msg;
        }
    }
}