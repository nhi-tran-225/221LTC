using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    class Program
    {
        public struct sinhvien
        {
            public string hoten140;
            public string msv140;
            public gioitinh gioitinh140;
            public double toan140;
            public double ly140;
            public double hoa140;

            
        };
        public enum gioitinh
        {
            Nam,
            Nu
        };
        public enum hocluc
        {
            Yeu,
            TrungBinh,
            Kha,
            Gioi
        };
        static void Main(string[] args)
        {
            Console.Write("Nhap so sinh vien: ");
            int n140 = int.Parse(Console.ReadLine());
            sinhvien[] sv140 = new sinhvien[n140];
            nhapDS(ref sv140, n140);
            Console.WriteLine("\n\n==========DANH SACH SINH VIEN==========");
            xuatDS(sv140, n140);

            Console.WriteLine("\n==========TIM KIEM SINH VIEN==========");
            Console.Write("Nhap ten sinh vien: ");
            string ht140 = Console.ReadLine();
            timKiem(sv140, n140, ht140);

            Console.ReadLine();
        }

        public static void nhapDS(ref sinhvien[] sv, int n)
        {
            for(int i=0; i<n; i++)
            {
                Console.WriteLine("Nhap sinh vien thu " + (i + 1));
                Console.Write("Ho ten: ");
                string ht140 = Console.ReadLine();
                Console.Write("Ma sinh vien: ");
                string msv140 = Console.ReadLine();
                Console.Write("Gioi tinh (0: nam  1: nu): ");
                int gt140 = int.Parse(Console.ReadLine());
                Console.Write("Diem toan: ");
                double dt140 = double.Parse(Console.ReadLine());
                Console.Write("Diem ly: ");
                double dl140 = double.Parse(Console.ReadLine());
                Console.Write("Diem hoa: ");
                double dh140 = double.Parse(Console.ReadLine());


                sv[i].hoten140 = ht140;
                sv[i].msv140 = msv140;
                if (gt140 == 0)
                    sv[i].gioitinh140 = gioitinh.Nam;
                else
                    sv[i].gioitinh140 = gioitinh.Nu;
                sv[i].toan140 = dt140;
                sv[i].ly140 = dl140;
                sv[i].hoa140 = dh140;

            }
        }
        public static hocluc diemTB(double toan, double ly, double hoa)
        {
            double dtb = (toan + ly + hoa) / 3;
            if (dtb <= 4)
                return hocluc.Yeu;
            else if (dtb <= 5)
                return hocluc.TrungBinh;
            else if (dtb <= 7)
                return hocluc.Kha;
            else
                return hocluc.Gioi;
        }
        public static void xuatDS(sinhvien[] sv, int n)
        {
            int i = 1;
            foreach(sinhvien item140 in sv)
            {
                Console.WriteLine("----- " + i + " -----");
                Console.WriteLine("Ho ten: " + item140.hoten140);
                Console.WriteLine("Ma sinh vien: " + item140.msv140);
                int gt = (int)item140.gioitinh140;
                if (gt == 0)
                    Console.WriteLine("Gioi tinh: Nam");
                else
                    Console.WriteLine("Gioi tinh: Nữ");
                Console.WriteLine("Diem toan: " + item140.toan140);
                Console.WriteLine("Diem ly: " + item140.ly140);
                Console.WriteLine("Diem hoa: " + item140.hoa140);
                int hocluc = (int)diemTB(item140.toan140, item140.ly140, item140.hoa140);
                switch(hocluc)
                {
                    case 0:
                        Console.WriteLine("Hoc luc: Yeu");
                        break;
                    case 1:
                        Console.WriteLine("Hoc luc: Trung Binh");
                        break;
                    case 2:
                        Console.WriteLine("Hoc luc: Kha");
                        break;
                    case 3:
                        Console.WriteLine("Hoc luc:Gioi");
                        break;

                }

                i++;
            }
        }
        public static void timKiem(sinhvien[] sv, int n, string ht)
        {
            foreach(sinhvien item140 in sv)
            {
                if(item140.hoten140 == ht)
                {
                    Console.WriteLine("Ho ten: " + item140.hoten140);
                    Console.WriteLine("Ma sinh vien: " + item140.msv140);
                    int gt = (int)item140.gioitinh140;
                    if (gt == 0)
                        Console.WriteLine("Gioi tinh: Nam");
                    else
                        Console.WriteLine("Gioi tinh: Nữ");
                    Console.WriteLine("Diem toan: " + item140.toan140);
                    Console.WriteLine("Diem ly: " + item140.ly140);
                    Console.WriteLine("Diem hoa: " + item140.hoa140);
                    int hocluc = (int)diemTB(item140.toan140, item140.ly140, item140.hoa140);
                    switch (hocluc)
                    {
                        case 0:
                            Console.WriteLine("Hoc luc: Yeu");
                            break;
                        case 1:
                            Console.WriteLine("Hoc luc: Trung Binh");
                            break;
                        case 2:
                            Console.WriteLine("Hoc luc: Kha");
                            break;
                        case 3:
                            Console.WriteLine("Hoc luc:Gioi");
                            break;

                    }
                }
            }
        }
    }
}
