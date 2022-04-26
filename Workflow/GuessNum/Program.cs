using System;

namespace GuessNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int input, count = 1, min = 0, max = 100;
            Random ran = new Random();
            int ans = ran.Next(1, 99);

            Console.WriteLine("== 猜數字遊戲 ==");
            Console.Write($"{count}.猜數字範圍：{min} < ? < {max}：");

            if (int.TryParse(Console.ReadLine(), out input))
            {
                while (ans != input)
                {
                    if (input > ans)
                    {
                        Console.WriteLine($"\t再小一點，你已經猜了{count}次\n");
                        max = input;
                    }
                    else if (input < ans)
                    {
                        Console.WriteLine($"\t再大一點，你已經猜了{count}次\n");
                        min = input;
                    }
                    count++;
                    Console.Write($"{count}.猜數字範圍：{min} < ? < {max}：");
                    input = int.Parse(Console.ReadLine());
                }
                Console.WriteLine($"  Bingo!一共猜了{count}次");
            }
            else
            {
                Console.WriteLine("輸入錯誤！");
            }
        }
    }
}
