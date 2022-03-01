using System;

namespace baitap
{
    class bai3

    {
        static void Main(string[] args)
        {
            float a140, b140, c140;
            Console.Write("Nhap canh a: ");
            a140 = float.Parse(Console.ReadLine());

            Console.Write("Nhap canh b: ");
            b140 = float.Parse(Console.ReadLine());

            Console.Write("Nhap canh c: ");
            c140 = float.Parse(Console.ReadLine());

            /* Kiem tra xem tong ba goc co bang 180 do */
            if (a140 <= 0 || b140 <= 0 || c140 <= 0)
                Console.Write("Day khong phai 3 canh cua tam giac\n");
            else
                Console.Write("Day la 3 canh cua tam giac\n");
            Console.ReadKey();

        }
    }
}
