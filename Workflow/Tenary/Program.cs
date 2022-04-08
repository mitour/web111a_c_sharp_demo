using System;

namespace Tenary
{
    class Program
    {
        static void Main(string[] args)
        {
            double netIncome = 0; // 淨所得
            double taxRate = 0;   // 稅率
            double tax = 0;       // 應繳稅額
            int discount = 0;     // 累淨差額
            int stage = 0;        // 級距

            Console.Write(">>>>  請輸入全年綜合所得淨額（元）：");
            netIncome = double.Parse(Console.ReadLine());

            if(netIncome > 0)
            {
                stage = (netIncome <= 520000) ? 1 : ((netIncome <= 1170000) ? 2 : ((netIncome <= 2350000) ? 3 : ((netIncome <= 4400000) ? 4 : (netIncome <= 10000000) ? 5 : 6)));
            }
            else
            {
                Console.WriteLine("== 不用繳稅");
            }

            switch (stage)
            {
                case 1:
                    taxRate = 0.05;
                    discount = 0;
                    break;
                case 2:
                    taxRate = 0.12;
                    discount = 36400;
                    break;
                case 3:
                    taxRate = 0.2;
                    discount = 130000;
                    break;
                case 4:
                    taxRate = 0.3;
                    discount = 365000;
                    break;
                case 5:
                    taxRate = 0.4;
                    discount = 805000;
                    break;
                case 6:
                    taxRate = 0.45;
                    discount = 1305000;
                    break;
                default:
                    Console.WriteLine("== 無此級距");
                    break;
            }

            tax = netIncome * taxRate - discount;
            Console.WriteLine($"\n== 1.綜合淨所得：{netIncome,0:C}元");
            Console.WriteLine($"== 2.所得稅級距：第{stage}級");
            Console.WriteLine($"== 3.累淨稅率：{taxRate:##.##%}");
            Console.WriteLine($"== 4.累淨差額：{discount,0:C}元");
            Console.WriteLine($"== 5.應繳稅額：{tax,0:C}元");
        }
    }
}
