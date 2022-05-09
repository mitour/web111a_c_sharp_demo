using System;

namespace recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int n, ans, ans3, ans4;
            double ans1;

            Console.Write("輸入：");
            input = Console.ReadLine();
            int.TryParse(input, out n);

            // 1. 輸入n，試算1+2+3+4+...+n
             int fn(int n)
            {
                if (n > 1) ans = n + fn(n-1);
                else ans =  1;
                return ans;
            }
            Console.WriteLine(fn(n));

            // 2. 試算 1 + 1/2 + 1/3 + 1/4 +...+ 1/n
            Double fn2(int n)
            {
                if (n > 1) ans1 = 1.0/n + fn2(n - 1);
                else ans1 = 1;
                return ans1;
            }
            Console.WriteLine(fn2(n));

            // 3. 試算 1 + 2! + 3! +...+ n!
            // 先算 n!
            int fn3(int n)
            {
                if (n > 1) ans3 = n * fn3(n - 1);
                else ans3 = 1;
                return ans3;
            }
            // 再算 1+ fn3(2) + fn3(3) + fn3(4) + fn3(5) +...+ fn(n)
            int fn4 (int n )
            {
                if (n > 1) ans4 = fn3(n) + fn4(n - 1);
                else ans4 = 1;
                return ans4;
            }
            Console.WriteLine(fn4(n));

        }
    }
}
