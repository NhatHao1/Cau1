using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao 3 so a, b, c: ");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            KiemTraTamGiac(a, b, c);

        }
        static void KiemTraTamGiac(double a, double b, double c)
        {
            if (a + b > c && a + c > b && b + c > a && a > 0 && b > 0 && c > 0)
            {
                Console.WriteLine("Day la ba canh cua mot tam giac");
                double p = (a + b + c) / 2.0;
                double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                double gocA = Math.Acos((b * b + c * c - a * a) / (2 * b * c)) * 180 / Math.PI;
                double gocB = Math.Acos((a * a + c * c - b * b) / (2 * a * c)) * 180 / Math.PI;
                double gocC = Math.Acos((a * a + b * b - c * c) / (2 * a * b)) * 180 / Math.PI;
                Console.WriteLine("\nBa goc cua tam giac la: \nGoc A = {0} \nGoc B = {1} \nGoc C = {2}", gocA, gocB, gocC);
            }
            else
            {
                Console.WriteLine("Day khong phai ba canh cua mot tam giac");
            }
        }
    }

}
