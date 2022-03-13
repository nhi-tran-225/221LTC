using System;
using System.Collections;
namespace Bai25
{
    class Program
    {
        /**
         * Tim uoc so chung lon nhat (USCLN)
         */
            static int USCLN(int a140, int b140)
            {
                if (b140 == 0) return a140;
                return USCLN(b140, a140 % b140);
            }

            /**
             * Tim boi so chung nho nhat (BSCNN)
             */
            static int BSCNN(int a140, int b140)
            {
                return (a140 * b140) / USCLN(a140, b140);
            }

            /**
            * Ham main
            */
            static void Main(string[] args)
            {
                Console.WriteLine("Nhap so nguyen duong a = ");
                String valA140 = Console.ReadLine();
                int a140 = Convert.ToInt32(valA140);
                Console.Write("Nhap so nguyen duong b = ");
                String valB140 = Console.ReadLine();
                int b140 = Convert.ToInt32(valB140);
                // tinh USCLN cua a và b
                Console.WriteLine("USCLN cua {0} va {1} la: {2} \n", a140, b140, USCLN(a140, b140));
                // tinh BSCNN cua a và b
                Console.WriteLine("USCLN cua cua {0} va {1} la: {2}", a140, b140, BSCNN(a140, b140));
            }
        }
    }
