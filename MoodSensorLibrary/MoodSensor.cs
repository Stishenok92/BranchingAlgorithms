using System;

namespace MoodSensorLibrary
{
    public class MoodSensor
    {
        public static int GetRandomNumber(int maxNumber)
        {
            Random random = new Random();
            return random.Next(maxNumber);
        }

        public static string ShowSmile(int numberSmile)
        {
            string msg;
            
            switch (numberSmile)
            {
                case 1: msg = ":‑D "; break;
                case 2: msg = ":-)"; break;
                case 3: msg = ":-|"; break;
                case 4: msg = ":‑X"; break;
                case 5: msg = ":-("; break;
                default: msg = "Sorry, no suitable smile!"; break;
            }

            return msg;
        }
    }
}