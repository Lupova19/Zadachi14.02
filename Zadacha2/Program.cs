using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vavedi r: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            Console.Write("Vavedi h: ");
            double height = Convert.ToDouble(Console.ReadLine());

            double cylinderSize = Math.PI * Math.Pow(radius, 2) * height; 
            double totalArea = 2 * Math.PI * radius * (radius + height); 

            Console.WriteLine($"V = {cylinderSize:F2}");
            Console.WriteLine($"S = {totalArea:F2}");
        }
    }
}
