using System;

namespace baitap
{
    class bai2
    {
        static void Main(string[] args)
        {
            int a140;
            Console.Write("Nhap so a: ");
            a140 = Convert.ToInt32(Console.ReadLine());
            switch (a140)
            {
                case 0:
                    {
                        Console.Write("không");
                        break;
                    }
                case 1:
                    Console.Write("Một");
                    break;
                case 2:
                    Console.Write("Hai");
                    break;
                case 3:
                    Console.Write("Ba");
                    break;
                case 4:
                    Console.Write("Bốn");
                    break;
                case 5:
                    Console.Write("Năm");
                    break;
                case 6:
                    Console.Write("Sáu");
                    break;
                case 7:
                    Console.Write("Bảy");
                    break;
                case 8:
                    Console.Write("Tám");
                    break;
                case 9:
                    Console.Write("Chín");
                    break;
            }
            Console.ReadKey();
        }
      
    }
}
