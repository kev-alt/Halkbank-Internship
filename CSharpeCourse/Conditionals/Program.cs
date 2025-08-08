using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalsExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            var number11 = -859;
            if (number11 >= 0 && number11 <= 100)
            {
                Console.WriteLine("Number is between 0-100");
            }
            else if (number11 > 100 && number11 <= 200)
            {
                Console.WriteLine("Number is between 101-200");
            }
            else if (number11 > 200 || number11 < 0)
            {
                Console.WriteLine("Number is less than 0 or greater than 200");
            }

            var number12 = 137;
            if (number12 < 100)
            {
                if (number12 >= 90 && number12 < 95)
                {
                    Console.WriteLine("Number is between 90-95");
                }
                else if (number12 >= 75 && number12 < 90)
                {
                    Console.WriteLine("Number is between 75-90");
                }
                else if (number12 >= 50 && number12 < 75)
                {
                    Console.WriteLine("Number is between 50-75");
                }
                else
                {
                    Console.WriteLine("Number is less than 100 but not between 50-95");
                }
            }
            else if (number12 >= 100 && number12 < 150)
            {
                Console.WriteLine("Number is between 100-150");
            }
            else
            {
                Console.WriteLine("Number is greater than 150");
            }

            Console.ReadLine();
        }
    }
}
