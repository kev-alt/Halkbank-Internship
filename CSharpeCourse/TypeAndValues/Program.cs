using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {

            // Value Types

            int number1 = 44; // -2147483648 - 2147483647
            long number2 = -789632155548; // -9223372036854775808 - 9223372036854775807
            short number3 = 32691; // -32768 - 32767
            byte number4 = 255; // 0 - 255
            bool condition = false; // true or false
            char character = 'k'; // holds a single character
            double number5 = 3.14; // holds decimal numbers
            decimal number6 = 3.14m; // for high-precision decimals 
            var number7 = 5; // implicitly typed as int
            // number7 = 'k'; // var type is fixed by the first value and can't be changed.


            Console.WriteLine("Number1 is {0}", number1);
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.WriteLine("Bool", condition);
            Console.WriteLine("Character is {0}", character);
            Console.WriteLine("Character is {0}", (int)character); // prints ASCII value of the character
            Console.WriteLine("Number5 is {0}", number5);
            Console.WriteLine("Number6 is {0}", number6);
            Console.WriteLine(Days.Wednesday);
            Console.WriteLine((int)Days.Wednesday);
            Console.WriteLine("Number7 is {0}", number7);

            //Console.WriteLine("Hello World! 🐄");
            Console.ReadLine();
        }
    }

    enum Days
    {

        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
}