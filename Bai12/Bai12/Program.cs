using System;

namespace Bai12
{
    class Program
    {
        static void Main(string[] args)
        {
            double a1140, b1140, c1140, a2140, b2140, c2140, dx140, dy140, d140, x140, y140;
            Console.Write("Nhap a1, b1, c1: ");
            a1140 = double.Parse(Console.ReadLine());
            b1140 = double.Parse(Console.ReadLine());
            c1140 = double.Parse(Console.ReadLine());

            Console.Write("Nhap a2, b2, c2: ");
            a2140 = double.Parse(Console.ReadLine());
            b2140 = double.Parse(Console.ReadLine());
            c2140 = double.Parse(Console.ReadLine());
    
            d140 = (a1140 * b2140 - a2140 * b1140);
            dx140 = (c1140 * b2140 - c2140 * b1140);
            dy140 = (a1140 * c2140 - a2140 * c1140);
            
            if (d140 == 0)
            {
                if (dx140 + dy140 == 0)
                    Console.WriteLine("He phuong trinh co vo so nghiem");
                else
                    Console.WriteLine("He phuong trinh vo nghiem");
            }
            else
            {
                x140 = dx140 / d140;
                y140 = dy140 / d140;
                Console.WriteLine($"He phuong trinh co nghiem (x, y) = ( {x140} , {y140} )");
            }    
        }
    }
}
