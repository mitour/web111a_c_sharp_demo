using System;

namespace IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 18;

            if (age >= 20)
            {
                Console.WriteLine("我是成年人！");
            }

            if(age >= 10 && age <= 19)
            {
                Console.WriteLine($"我是青少年，年紀是{age}");
            }
            else
            {
                Console.WriteLine($"我不是青少年，年紀是{age}");
            }
        }
    }
}
