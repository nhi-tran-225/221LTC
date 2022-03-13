using System;

namespace Bai18
{
    class Program
    {
        static void Main(string[] args)
        {
            long h140, t140, n140;
            Console.Write("Nhap so gio: ");
            h140 = long.Parse(Console.ReadLine());

            t140 = h140 / (24 * 7);
            n140 = (h140 % (24 * 7)) / 24;
            h140 = (h140 % (24 * 7)) % 24;

            Console.WriteLine($"{t140} tuan, {n140} ngay, {h140} gio");
            Console.ReadKey();
        }
    }
}
