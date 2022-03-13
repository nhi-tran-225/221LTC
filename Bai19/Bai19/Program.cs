using System;

namespace Bai19
{
    class Program
    {
        static void Main(string[] args)
        {
            int h140, m140, s140;
            long time140, hh140, hm140, hs140;
            Console.WriteLine("Nhap gio, phut, giay [1]: ");
            h140 = int.Parse(Console.ReadLine());
            m140 = int.Parse(Console.ReadLine());
            s140 = int.Parse(Console.ReadLine());

            time140 = 3600 * h140 + 60 * m140 + s140;

            Console.WriteLine("Nhap gio, phut, giay [2]: ");
            h140 = int.Parse(Console.ReadLine());
            m140 = int.Parse(Console.ReadLine());
            s140 = int.Parse(Console.ReadLine());

            time140 -= 3600 * h140 + 60 * m140 + s140;
            if (time140 < 0) { 
                time140 = -time140; 
            }

            hh140 = time140 / 3600;
            hm140 = (time140 % 3600) / 60;
            hs140 = (time140 % 3600) % 60;

            Console.WriteLine($"Hieu thoi gian: {hh140} gio, {hm140} phut, {hs140} giay");
            Console.ReadKey();
        }
    }
}
