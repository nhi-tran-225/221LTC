using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ktra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap a,b,c: ");
            double a = Int32.Parse(Console.ReadLine());
            double b = Int32.Parse(Console.ReadLine());
            double c = Int32.Parse(Console.ReadLine());
            ptb2 pt = new ptb2(a, b, c);

            double delta = pt.delta(a, b, c);
            int check = pt.TinhNghiem(delta);
            if (check < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
            else if (check == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("Phuong trinh co nghiem kep: ", x);
            }
            else
            {
                double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b + Math.Sqrt(delta)) / (2 * a);

                Console.WriteLine("Phuong trinh co 2 nghiem x1={0} , x2={1}: ", x1, x2);
            }
        }
    }

    class ptb2
    {
        private double a;
        private double b;
        private double c;

        public ptb2()
        {
        }

        public ptb2(double a, double b, double c)
        {
            ts1 = a;
            ts2 = b;
            ts3 = c;
        }

        public double ts1 { get; set; }
        public double ts2 { get; set; }
        public double ts3 { get; set; }

        public double delta(double a, double b, double c)
        {
            return b * b - 4 * a * c;
        }

        public int TinhNghiem(double delta)
        {
            if (delta < 0)
            {
                return -1;
            }
            else if (delta == 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}