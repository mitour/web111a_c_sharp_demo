using System;

namespace NestedIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;

            Console.Write("請輸入第一個數字：");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("請輸入第二個數字：");
            n2 = int.Parse(Console.ReadLine());
            Console.Write("請輸入第三個數字：");
            n3 = int.Parse(Console.ReadLine());

            if(n1 > n2)
            {
                if(n1 > n3)
                {
                    Console.WriteLine($"最大值是：{n1}");
                }
                else
                {
                    Console.WriteLine($"最大值是：{n3}");
                }
            }
            else
            {
                if (n2 > n3)
                {
                    Console.WriteLine($"最大值是：{n2}");
                }
                else
                {
                    Console.WriteLine($"最大值是：{n3}");
                }
            }
        }
    }
}
