using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k, n = 6;
            string str, s = "*", t = " ";
            for(i = 1; i <= n; i++)
            {
                str = "";
                for(j = 1; j <= i; j++)
                {
                    str += s + t;
                }
                Console.WriteLine(str);
            }
            Console.WriteLine("===========正三角");
            for(i = 1; i <= n; i++)
            {
                str = "";
                for (k = 1; k <= n - i; k++)
                {
                    str += t;
                }
                for (j = 1; j <= i; j++)
                {
                    str += s + t;
                }
                Console.WriteLine(str);
            }
            Console.WriteLine("===========偏右正三角");
            for (i = 1; i <= n; i++)
            {
                str = "";
                for (k = 1; k <= n - i; k++)
                {
                    str += t + t;
                }
                for (j = 1; j <= i; j++)
                {
                    str += s + t;
                }
                Console.WriteLine(str);
            }
            Console.WriteLine("===========偏左倒三角");
            for (i = 1; i <= n; i++)
            {
                str = "";
                for (j = n; j >= i; j--)
                {
                    str += s + t;
                }
                Console.WriteLine(str);
            }
            Console.WriteLine("===========正倒三角");
            for (i = 1; i <= n; i++)
            {
                str = "";
                for (k = 1; k <= i - 1; k++)
                {
                    str += t;
                }
                for (j = n; j >= i; j--)
                {
                    str += s + t;
                }
                Console.WriteLine(str);
            }
            Console.WriteLine("===========偏右倒三角");
            for (i = 1; i <= n; i++)
            {
                str = "";
                for (k = 1; k <= i - 1; k++)
                {
                    str += t + t;
                }
                for (j = n; j >= i; j--)
                {
                    str += s + t;
                }
                Console.WriteLine(str);
            }
        }
    }
}
