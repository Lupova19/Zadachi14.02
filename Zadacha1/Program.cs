using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Vavedi a:");
                double a = double.Parse(Console.ReadLine());

                Console.Write("Vavedi b:");
                double b = double.Parse(Console.ReadLine());

                Console.Write("Vavedi c:");
                double c = double.Parse(Console.ReadLine());

                if (a + b > c && a + c > b && b + c > a)
                {
                    double P = a + b + c;
                    Console.WriteLine($"P = {P}");

                    double p = P / 2;
                    double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                    Console.WriteLine($"S = {S:F2}");
                }
                else
                {
                    Console.WriteLine("Nqma takav triagalnik!!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
