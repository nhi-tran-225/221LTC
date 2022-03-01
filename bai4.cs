using System;

namespace baitap
{
    class bai4
    {
        static void Main(string[] args)
        {

            int a140, b140, c140;
            Console.Write("Nhap canh a: ");
            a140 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap canh b: ");
            b140 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap canh c: ");
            c140 = Convert.ToInt32(Console.ReadLine());

            /* Kiem tra xem tong ba goc co bang 180 do */
            if (a140 <= 0 || b140 <= 0 || c140 <= 0)
                Console.Write("Day khong phai la 3 canh cua tam giac\n");
            else
            {
                    {
                        if (a140 * a140 + b140 * b140 == c140 * c140 || a140 * c140 + c140 * c140 == b140 * b140 || b140 * b140 + c140 * c140 == a140 * c140)
                        {
                            Console.Write("Day la tam giac vuong.\n");
                        }
                        else
                            Console.Write("Day la tam giac thuong.\n");
                    }
                }
            
            Console.ReadKey();
        }
    }
}

