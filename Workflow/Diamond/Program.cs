using System;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            // i直回圈、j橫回圈、k位置、n邊長、x每行星星數量、m菱形邊長
            int i, j, k=1, n, x=1, shape, m;
            string s = "*", t = " ";
            Console.Write("請輸入邊長：");

            if(int.TryParse(Console.ReadLine(), out n))
            {
                Console.Write("請輸入要畫的圖形：(1)正三角、(2)倒三角、(3)菱形、(4)空心菱形：");
                if (int.TryParse(Console.ReadLine(), out shape))
                {
                    switch (shape)
                    {
                        case 1:
                            for (i = 1; i <= n; i++)
                            {
                                for (j = 1; j <= n - i; j++) Console.Write(t);
                                for (k = 1; k <= i; k++) Console.Write(s+t);
                                Console.WriteLine("");
                            }
                            break;
                        case 2:
                            for (i = 1; i <= n; i++)
                            {
                                for (j = 1; j <= i - 1; j++) Console.Write(t);
                                for (k = 1; k <= n - i + 1; k++) Console.Write(s+t);
                                Console.WriteLine("");
                            }
                            break;
                        case 3:
                            /*
                            // method 1
                            for (i = 1; i <= n; i++)
                            {
                                for (j = 1; j <= n - i; j++) Console.Write(t);
                                for (k = 1; k <= i; k++) Console.Write(s+t);
                                Console.WriteLine("");
                            }
                            for (i = 1; i <= n; i++)
                            {
                                for (j = 1; j <= i; j++) Console.Write(t);
                                for (k = 1; k <= n - i; k++) Console.Write(s+t);
                                Console.WriteLine("");
                            }
                            */

                            // method 2
                            for (i = 1; i <= 2 * n - 1; i++)
                            {
                                for (j = 1; j <= 2 * n - 1; j++)
                                {
                                    // k = 5, 4, 3, 2, 1, 2, 3, 4, 5...
                                    k = i <= n ? n - i + 1 : i - n + 1;
                                    if (j >= k && j < k + x)
                                    {
                                        Console.Write(s);
                                    }
                                    else
                                    {
                                        Console.Write(t);
                                    }
                                }
                                // x = 1,3,5,7,9,7,5,3,1
                                x = i < n ? x + 2 : x - 2;
                                Console.WriteLine();
                            }
                            break;
                        case 4:
                            Console.Write("請輸入菱形厚度：");
                            if (int.TryParse(Console.ReadLine(), out m))
                            {
                                for (i = 1; i <= 2 * n - 1; i++)
                                {
                                    for (j = 1; j <= 2 * n - 1; j++)
                                    {
                                        // k = 5, 4, 3, 2, 1, 2, 3, 4, 5...
                                        k = i <= n ? n - i + 1 : i - n + 1;
                                        // j >= k && j < k + x 菱形左邊的邊
                                        // (j < (k + m) || j > (2 * n - k - m)) 菱形右邊的邊
                                        if (j >= k && j < k + x && (j < (k + m) || j > (2 * n - k - m)) )
                                        {
                                            Console.Write(s);
                                        }
                                        else
                                        {
                                            Console.Write(t);
                                        }
                                    }
                                    // x = 1,3,5,7,9,7,5,3,1
                                    x = i < n ? x + 2 : x - 2;
                                    Console.WriteLine();
                                }
                            }
                            break;
                        default:
                            Console.Write("輸入錯誤！");
                            break;
                    }
                    
                }
            }
            
        }
    }
}
