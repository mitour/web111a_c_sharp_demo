using System;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string ans;
            Console.WriteLine("題目：\n請問 Visual Studio 可以開發下列哪種應用程式\n1.視窗程式2.Web程式3.裝置應用程式4.以上皆是");
            Console.Write("請作答：");
            ans = Console.ReadLine();
            /*
            if (ans == "4")
            {
                Console.WriteLine("=== 答對了，真不愧是 .NET 達人....");
            }
            else if (ans == "1" || ans == "2" || ans == "3")
            {
                Console.WriteLine("=== 答錯了，正確答案是4.");
            }
            else
            {
                Console.WriteLine("=== 無此選項....");
            }
            */

            // same case via switch/case
            switch(ans)
            {
                case "1":
                case "2":
                case "3":
                    Console.WriteLine("=== 答錯了，正確答案是4.");
                    break;
                case "4":
                    Console.WriteLine("=== 答對了，真不愧是 .NET 達人....");
                    break;
                default:
                    Console.WriteLine("=== 無此選項....");
                    break;
            }
        }
    }
}
