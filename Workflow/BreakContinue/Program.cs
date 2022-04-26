using System;

namespace BreakContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            int upper, N = 0, sum = 0;
            Console.WriteLine("== 求1+2+3+...+N <= Upper（臨界值）");
            Console.Write("\n1.請輸入臨界值：");
            upper = int.Parse(Console.ReadLine());

            for(int i = 1; i <= upper; i++)
            {
                sum += i;
                if (sum > upper)
                {
                    sum -= i;
                    N = i-1;
                    break;
                }
            }
            Console.WriteLine($"\n2.電腦自動算出N為：{N}");
            Console.WriteLine($"\n3.1+2+3+...+{N}={sum}");

        }
    }
}
