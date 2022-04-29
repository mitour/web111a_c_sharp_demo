using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int n;

            Console.Write("Enter a number: ");
            input = Console.ReadLine();

            int.TryParse(input, out n);
            for(int i = 1; i <= n; i++)
            {
                Console.Write(fib(i)+"\t");

                if (i % 5 == 0)
                {
                    Console.WriteLine("");
                }
            }

            static int fib(int n)
            {
                if(n==1 || n == 2)
                {
                    return 1;
                }
                else
                {
                    return fib(n - 1) + fib(n - 2);
                }
            }
        }
    }
}
