using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class Program
    {
        static void If6(int a, int b)

        {
            if (a > b)
            {
                Console.WriteLine(a);
            }
            else
                Console.WriteLine(b);
        }
        static void If28(int year)
        {
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                Console.WriteLine("високосный год");
            }
            else
            {
                Console.WriteLine("обычный год");
            }

        }
        static void If12(int a, int b, int c)
        {
         



        }

        static void Main(string[] args)
        {
            int a = 8;
            int b = 10;
            If6(a, b);
            int year = 8;
            If28(year);
            
        }

    }
}


