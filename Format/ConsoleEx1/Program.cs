using System;

namespace ConsoleEx1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int price;
            Console.Write("請輸入品名：");
            name = Console.ReadLine();
            Console.Write("請輸入單價：");
            price = int.Parse(Console.ReadLine());
            Console.WriteLine($"品名：{name} 單價：{price} 記錄儲存成功");
        }
    }
}
