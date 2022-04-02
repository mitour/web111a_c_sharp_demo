using System;

namespace StringFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //.NET string format
            Console.WriteLine("12345678901234567890");
            Console.WriteLine(string.Format("{0, 0 :C}   {1, 0 :c3}\n{2, 15 :c3}\n{3, -15 :c3}", 5, -5, -5, -5));
            // 完整寫法
            Console.WriteLine("{0, 0 :C}   {1, 0 :c3}\n{2, 15 :c3}\n{3, -15 :c3}", 5, -5, -5, -5);
            // 字串加值的寫法
            Console.WriteLine($"{5,0:c}   {-5,0:c3}\n{-5,15:c3}\n{-5,-15:c3}");

            // HW1:
            Console.WriteLine("1. 以貨幣方式C|c顯示資料，以NT$開頭====");
            Console.WriteLine("12345678901234567890");
            Console.WriteLine($"{1234}{'/'}{-1234}{'/'}{123.4}");
            Console.WriteLine($"{5, 0 :c}  {-5, 0 :c3}\n{-5, 15 :c3}\n{-5, 0 :c3}\n");

            Console.WriteLine("2. 以十進位方式D|d顯示資料，空白處補零====");
            Console.WriteLine("12345678901234567890");
            Console.WriteLine($"{25, 0 :d5}\n{25, 10 :d5}\n{-25, 0 :d5}\n");

            Console.WriteLine("3. 以指數方式E顯示資料====");
            Console.WriteLine("12345678901234567890");
            Console.WriteLine($"{250000, 0 :E}\n{25000, 0 :E3}\n{1.2345, 0 :E3}\n{25000, 20 :E3}\n{-25000, -20:E3}\n");

            Console.WriteLine("4. 以浮點數方式F|f顯示資料====");
            Console.WriteLine("12345678901234567890");
            Console.WriteLine($"{123.456, 0 :f2}\n{123, 0 :f0}\n{123.456, 0 :f3}\n{123.4567, 20 :f2}\n{-123.45, -20 :f3}\n");

            Console.WriteLine("5. 以一般方式G|g顯示資料====");
            Console.WriteLine("12345678901234567890");
            Console.WriteLine($"{123.4567 ,0 :g}\n{123.4567, 0 :g7}\n{123.4567, 0 :g3}\n{123.4567, 20 :g5}\n{-123.4567, -20 :g3}\n");

            Console.WriteLine("6. 以千位方式N|n顯示資料，不加$====");
            Console.WriteLine("12345678901234567890");
            Console.WriteLine($"{2500000, 0 :n2}\n{2500000, 0 :n0}\n{2500000, 0 :n1}\n{-2500000, 20 :n2}\n{2500000, -20 :n2}\n");

            Console.WriteLine("7. 以十六進位方式X|x顯示資料====");
            Console.WriteLine("12345678901234567890");
            Console.WriteLine($"{255, 0 :X}\n{255, 10 :X}\n{255, -10 :X}\n{12, 0 :x4}\n{12, 2 :x}");
            
            // HW2
            Console.WriteLine("1. " + 0801234567.ToString("(0##) ###-####"));
            Console.WriteLine("2. " + 12345.ToString("-#####"));
            Console.WriteLine("3. " + 12345.ToString("-0#####"));
            Console.WriteLine("4. " + 2.46.ToString("-#.##"));
            Console.WriteLine("5. " + 2.4.ToString("-0.00"));
            Console.WriteLine("6. " + 2.46.ToString("-00.00"));
            Console.WriteLine("7. " + 1234567890.ToString("#,#"));
            Console.WriteLine("8. " + 1234567890.ToString("#,"));
            Console.WriteLine("9. " + 1234567890.ToString("#,,"));
            Console.WriteLine("10. " + 1234567890.ToString("#,,,"));
            Console.WriteLine("11. " + 1234567890.ToString("#,0,,"));
            Console.WriteLine("12. " + .086.ToString("#.##%"));
            Console.WriteLine("13. " + .0865.ToString("#.###%"));
            Console.WriteLine("14. " + 16800.ToString("0.###E+0"));
            Console.WriteLine("15. " + 16800.ToString("0.###E+000"));
            Console.WriteLine("16. " + 16800.ToString("0.###E-000"));
            Console.WriteLine("17. " + 123456.ToString("[##-##-##]"));
            Console.WriteLine("18. " + 1234.ToString("#"));
            Console.WriteLine("19. " + 1234.ToString("(#)"));
            Console.WriteLine("20. " + 1234.ToString("(#)"));

        }
    }
}
