using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vavedi chislo: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num < 100 || num > 999)
            {
                Console.WriteLine("Vavedi validno chislo!");
                return;
            }

            int numHundreds = num / 100;         
            int numTens = (num / 10) % 10;       
            int numOnes = num % 10;             

            Console.WriteLine($"Cifrata na stoticite: {numHundreds}");
            Console.WriteLine($"Cifrata na deseticite: {numTens}");
            Console.WriteLine($"Cifrata na edinicite: {numOnes}");
        }
    }
}
