using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    // {i*j, 2} 代表format結果在兩位數
                    Console.Write($"{j}*{i} = {i*j, 2}  ");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"=====每三個一組=====");

            // 九九乘法 每三個一組
            for(int k = 1; k <= 9; k+=3)
            {
                for(int i = 1; i <= 9; i++)
                {
                    for(int j = k; j<=(k+2); j++)
                    {
                        Console.Write($"{j}*{i} = {i*j, 2}\t");
                    }
                    Console.WriteLine("");

                }
                Console.WriteLine("");
            }
        }
    }
}
