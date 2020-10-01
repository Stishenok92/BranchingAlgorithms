using static MoodSensorLibrary.MoodSensor;
using System;


namespace MoodSensorProgram
{
    class Program
    {
        public const int NUMBER_OF_SMILIES = 7;
        
        static void Main(string[] args)
        {
            Console.WriteLine("Task #01. Mood sensor\n");
            Console.WriteLine(ShowSmile(GetRandomNumber(NUMBER_OF_SMILIES)));
        }
    }
}