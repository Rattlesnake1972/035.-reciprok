using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _035.reciprok
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            Console.WriteLine("Kérek egy számot és kiírom a reciprokát!");
            Console.Write("a=");
            a = double.Parse(Console.ReadLine());
            double c = 1 / a;

            Console.WriteLine("A számod reciproka: " + c);

            Console.ReadKey();
        }
    }
}
