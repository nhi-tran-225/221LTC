using System;

namespace Bai33
{
    class Program
    {
        static void Main(string[] args)
        {
            long i140, j140, s140;
            Console.WriteLine("So Amstrong co 3, 4 chu so: ");
            /* i dùng duyệt các số có 3, 4 chữ số */
            for (i140 = 100; i140 < 9999; ++i140)
            {
                /* j dùng tách các chữ số của i ra để kiểm tra */
                for (s140 = 0, j140 = i140; s140 <= i140 && j140 > 0; j140 /= 10)
                    s140 += (long)Math.Pow(j140 % 10, i140 < 1000 ? 3 : 4);
                if (i140 == s140) Console.WriteLine($"{i140}");
            }
        }
    }
}