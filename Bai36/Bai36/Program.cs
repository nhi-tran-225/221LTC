using System;

namespace Bai36
{
    class Program
    {
        static void Main(string[] args)
        {
            long n140, k140, i140, count140;
            Console.WriteLine("Nhap n: ");
            n140 = long.Parse(Console.ReadLine());
            k140 = 2;
            count140 = 0;
            while (count140 < n140)
            { /* vòng lặp kiểm tra k có phải là số nguyên tố */
                for (i140 = 2; i140 * i140 <= k140; ++i140)
                    if (k140 % i140 == 0) break;
                if (i140 * i140 > k140)
                {
                    Console.WriteLine($"{k140}");
                    count140++;
                }
                k140++;
            }
        }
    }
}
