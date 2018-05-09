using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
      
        static void Main(string[] args)
        {
                      
           Console.WriteLine("Enter the length of first side ");
           int  a = Convert.ToInt32(Console.ReadLine());

           Console.WriteLine("Enter the length of second side ");
           int b = Convert.ToInt32(Console.ReadLine());

           Console.WriteLine("Enter the length of third side ");
           int c = Convert.ToInt32(Console.ReadLine());

            if (a == b && b == c)
            {
                Console.WriteLine("Triangle is equilateral ");
            }
            else if (a==b||a==c||b==c)
            {
                Console.WriteLine("Triangle is isosceles  ");
            }
            else
            {
                Console.Write("Triangle is scalene");
            }
            Console.ReadKey();
        }
    }
}
