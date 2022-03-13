using System;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a140, b140;
            Console.Write("Nhap dien tich mat cau = ");
            a140 = double.Parse(Console.ReadLine());
            b140 = (4 * 3.14 * Math.Pow(Math.Sqrt(a140 / (4 * 3.14)), 3)) / 3;
            Console.WriteLine($"The tich V = {b140}");
            Console.ReadKey();
        }
    }
}
