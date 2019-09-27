using System;

namespace SetAlarm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Are you employed? Enter true or false");
            bool employed = bool.Parse(Console.ReadLine().ToLower());
            Console.WriteLine("Are you on vacation? Enter true or false");
            bool vacation = bool.Parse(Console.ReadLine().ToLower());

            bool AlarmOutput = Alarm.SetAlarm(employed, vacation);

            if (AlarmOutput)
            {
                Console.WriteLine("You need to set an alarm since you have work you lazy bitch.");
            }
            else
            {
                Console.WriteLine("You can sleep in, you lazy bitch");
            }
        }
    }
}
