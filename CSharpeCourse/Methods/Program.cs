using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
            Add();
            Add2(46, 38);
            var result = Add2(81, 78);
            Console.WriteLine(result);

            int number1 = 28;
            int number2 = 852;
            int number3;
            int number4 = 85;
            var result2 = Add3(ref number1, number2); // 'ref': number1 is modified inside the method and the change is reflected back to the caller.
            var result3 = Add4(out number3, number4); // 'out': number3 is initialized inside the method and passed back to the caller.
            Console.WriteLine(result2);
            Console.WriteLine(number1);
            Console.WriteLine(Multiply(3, 9));
            Console.WriteLine(Multiply(5, 7, 6));
            Console.WriteLine(Add4(3, 5, 8, 8, 8, 2));


            Console.ReadLine();
        }

        static void Add()
        {
            { }
            Console.WriteLine("Added!");
        }

        static int Add2(int number1, int number2 = 47) // Default value: if number2 is not provided, 47 is used; otherwise, the given value overrides it.
        {
            //return number1 + number2;

            var result = number1 + number2;
            return result;
        }

        static int Add3(ref int number1, int number2)
        {
            number1 = 56;
            return number1 + number2;
        }

        static int Add4(out int number3, int number4)
        {
            number3 = 51;
            return number3 + number4;
        }

        static int Multiply(int number5, int number6)
        {
            return number5 * number6;
        }
        static int Multiply(int number7, int number8, int number9) // Method Overloading: Same method name defined multiple times with different number or types of parameters.
        {
            return number7 * number8 * number9;
        }

        static int Add4(params int[] numbers) // params: Allows passing a variable number of int arguments; received as an array.
        {
            return numbers.Sum();
        }

    }
}