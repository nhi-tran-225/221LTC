using System;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a140, b140, x140, y140, kq140;
            Console.Write("Nhap toa do diem A  ");
            a140 = double.Parse(Console.ReadLine());
            b140 = double.Parse(Console.ReadLine());
            Console.Write("Nhap toa do diem B  ");
            x140 = double.Parse(Console.ReadLine());
            y140 = double.Parse(Console.ReadLine());
            kq140 = Math.Sqrt((x140 - a140) * (x140 - a140) + (y140 - b140) * (y140 - b140));
            Console.WriteLine($"Khoang cach AB = {kq140}");
            Console.ReadKey();
        }
    }
}
