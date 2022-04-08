using System;

namespace ConsoleNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 5;
            switch (i)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 9:
                    Console.WriteLine($"{i}為奇數");
                    break;
                case 2:
                case 4:
                case 6:
                case 8:
                    Console.WriteLine($"{i}為偶數");
                    break;
                default:
                    Console.WriteLine("Other");
                    break;
            }
        }
    }
}
