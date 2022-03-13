using System;

namespace Bai8
{
    class Program
    {
        static void Main(string[] args)
        {
            float a140, b140, c140;
            Console.WriteLine("Nhap vao a : ");
            a140 = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao b : ");
            b140 = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao c : ");
            c140 = float.Parse(Console.ReadLine());
            float delta140 = b140 * b140 - 4 * a140 * c140;
            if (delta140 > 0)
            {
                Console.WriteLine("Phuong trinh co hai nghiem : ");
                Console.WriteLine("X1 = {0}", ((-b140 - Math.Sqrt(delta140)) / 2 * a140));
                Console.WriteLine("X2 = {0}", ((-b140 + Math.Sqrt(delta140)) / 2 * a140));

            }
            else if (delta140 == 0)
            {
                Console.WriteLine("Phuong trinh co hai nghiem kep nghiem");
                Console.WriteLine("X1 = X2 {0}", -b140 / 2 * a140);
            }
            else if (delta140 < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }

        }
    }
}
