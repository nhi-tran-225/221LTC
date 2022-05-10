using System;

namespace BTDiemDanh
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr140 = new int[20];
            int i140 = 0;
            Console.WriteLine("Nhap 10 so: ");
            while (i140 >= 10 || !int.TryParse(Console.ReadLine(), out arr140[i++]))
            {
                break;
            }
            if (arr140.Length != 10)
                goto exit;
            else
            {
                int max140 = arr140[0], min140 = arr140[0], tmp140;
                for (i140 = 1; i140 < arr140.Length; i140++)
                {
                    if (arr140[i140] > max140)
                    {
                        max140 = arr140[i140];
                    }
                    if (arr140[i140] < min140)
                    {
                        min140 = arr140[i140];
                    }
                }
                for (int j140 = 0; j140 < arr140.Length; j140++)
                {
                    for (int k140 = 0; k140 < arr140.Length; k140++)
                    {
                        if (arr140[j140] > arr140[k140])
                            tmp140 = arr140[j140];
                        arr140[j140] = arr140[k140];
                        arr140[k140] = tmp140;
                    }
                }
                Console.WriteLine("Max = ", max140);
                Console.WriteLine("Min = ", min140);
                for (int m140 = 0; m140 < arr140.Length; m140++)
                {
                    Console.Write(arr140[m140] + "  ");
                }
            }
        exit:
            Console.WriteLine("Exit");
        }
    }
}
