using System;

namespace ConsoleShift
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            n = n << 1;
            Console.WriteLine($"n=n<<1 左移一位：{n}");

            n = n << 2;
            Console.WriteLine($"n=n<<2 左移兩位：{n}");

            n = n >> 2;
            Console.WriteLine($"n=n>>2 右移兩位：{n}");

            n = n >> 1;
            Console.WriteLine($"n=n>>1 右移一位：{n}\n");

            char c1 = '9';
            char c2 = '2';
            char c3 = '1';
            Console.WriteLine($"原編碼訊息：{c1}{c2}{c3}");
            int key = 11;

            c1 = (char)(c1 ^ key);
            c2 = (char)(c2 ^ key);
            c3 = (char)(c3 ^ key);
            Console.WriteLine($"編碼後訊息：{c1}{c2}{c3}");

            c1 = (char)(c1 ^ key);
            c2 = (char)(c2 ^ key);
            c3 = (char)(c3 ^ key);
            Console.WriteLine($"解碼後訊息：{c1}{c2}{c3}");
        }
    }
}
