using System;

namespace baitap
{
    class bai1
    {
        static void Main(string[] args)
        {
            int a140;
            Console.Write("Nhap so a = ");
            a140 = int.Parse(Console.ReadLine());
            if (a140 > 0)
                Console.WriteLine($"{a140} la so nguyen duong");
            if (a140 < 0)
                Console.WriteLine($"{a140} la so nguyen am");
            Console.ReadKey();
        }
    }
}
