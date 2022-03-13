using System;

namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            double xC140, yC140, bk140, xM140, yM140, d140;
            Console.Write("Nhap toa do tam C  ");
            xC140 = double.Parse(Console.ReadLine());
            yC140 = double.Parse(Console.ReadLine());

            Console.Write("Nhap ban kinh R  ");
            bk140 = double.Parse(Console.ReadLine());

            Console.Write("Nhap toa do diem M  ");
            xM140 = double.Parse(Console.ReadLine());
            yM140 = double.Parse(Console.ReadLine());

            d140 = bk140 - Math.Sqrt((xM140 - xC140) * (xM140 - xC140) + (yM140 - yC140) * (yM140 - yC140));

            if (d140 > 0)
                Console.WriteLine("M nam trong C()\n");
            else if (d140 < 0)
                Console.WriteLine("M nam ngoai C()\n");
            else 
                Console.WriteLine("M nam tren C()\n");
            Console.ReadKey();
        }
    }
}
