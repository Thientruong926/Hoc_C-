using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS01_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap tham so a: ");
            double a=double.Parse(Console.ReadLine());
            Console.Write("Nhap tham so b: ");
            double b=double.Parse(Console.ReadLine());
            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("Phuong trinh co vo so nghiem");
                }
                else
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                }
            }
            else
            {
                double x = -b / a;
                Console.WriteLine("Phuong trinh co nghiem x= " + x);
            }
            Console.ReadKey();
        }
    }
}
