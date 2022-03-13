using System;

namespace Bai23
{
    class Program
    {
        static void Main(string[] args)
        {
            long n140, sum140;
            Console.WriteLine("Nhap n: ");
            n140 = long.Parse(Console.ReadLine());
            for (int number = 1; number <= n140; number++)
            {
                sum140 = 0;
                for (int i140 = 1; i140 <= number; i140++)
                    if (number % i140 == 0)
                        sum140 += i140;
                if (sum140 / 2.0 == number)
                    Console.WriteLine($"{number} ");
            }
            Console.ReadKey();
        }
    }
}
