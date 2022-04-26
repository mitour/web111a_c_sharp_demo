using System;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0, score, average = 0;
            string flag;
            Console.WriteLine("== 程式語言設計成績計算 ==");

            do
            {
                count++;
                Console.Write($"\n{count}.請輸入第{count}位同學成績：");
                score = int.Parse(Console.ReadLine());

                average += score;
                
                Console.Write("\n== continue? (y/n) ");
                flag = Console.ReadLine();
            } while (flag == "y" || flag == "Y");

            average = average / count;
            Console.WriteLine($"\n== 共輸入{count}位同學成績，班上平均成績：{average}");

        }
    }
}
