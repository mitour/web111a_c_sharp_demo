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
        }
    }
}
