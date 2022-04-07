using System;

namespace ConsoleEnum
{
    class Program
    {
        enum WeekDays : int
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thurday = 4,
            Friday = 5,
            Saturday = 6,
            Sunday = 7
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"星期三咧舉常數值：{(int)WeekDays.Wednesday}");
            Console.WriteLine($"星期五咧舉常數值：{(int)WeekDays.Friday}");

        }
    }
}
