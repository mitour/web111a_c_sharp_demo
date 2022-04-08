using System;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            string pwd = "best";

            // sol1
            for(int i = 1; i <= 3; i++) {
                Console.Write("enter password:");
                input = Console.ReadLine();
                if(input == pwd)
                {
                    Console.WriteLine("=== 登入成功歡迎進入本系統");
                    break;
                }
                else
                {
                    Console.WriteLine($"Sorry! 密碼錯誤{i}次，請重新輸入\n");
                }
                if (i == 3)
                {
                    Console.WriteLine("access denied");
                }
            }

            // sol2
            bool flag = false;
            for (int i = 1; i <= 3; i++)
            {
                Console.Write("enter password:");
                input = Console.ReadLine();
                if (input == pwd)
                {
                    flag = true;
                    break;
                }
                else
                {
                    Console.WriteLine($"Sorry! 密碼錯誤{i}次，請重新輸入\n");
                }
            }
            if (flag)
            {
                Console.WriteLine("=== 登入成功歡迎進入本系統");
            }
            else
            {
                Console.WriteLine("access denied");
            }


            for (int i = 1; i <= 5; i++)
            {
                for(int k = 1; k<=i; k++)
                {
                    Console.Write(k+" ");
                }
                Console.Write("\n");
            }
        }
    }
}
