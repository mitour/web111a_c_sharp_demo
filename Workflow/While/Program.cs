using System;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            int input, count = 0, i = 1;

            Console.Write("請輸入欲求因數的數值(1-50)：");
            //input = int.Parse(Console.ReadLine());

            if(int.TryParse(Console.ReadLine(), out input))
            {
                if (input >= 1 && input <= 100)
                {
                    Console.WriteLine($"\n== 求1-100能被{input}整除的因數 ==\n");
                    while (i <= 100)
                    {
                        if (i % input == 0)
                        {
                            Console.Write($"\t{i},");
                            count++;

                            if (count % 5 == 0)
                            {
                                Console.Write("\n");
                            }
                        }
                        i++;
                    }
                    Console.WriteLine($"\n== 由1-100共有{count}個能被{input}整除！ ==\n");
                }
                else
                {
                    Console.WriteLine("== 超出範圍(1-50)");

                }
            }
            else
            {
                Console.WriteLine("請輸入整數");
            }
        }
    }
}
