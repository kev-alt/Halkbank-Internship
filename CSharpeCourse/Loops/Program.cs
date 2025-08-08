namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            ForLoop();
            WhileLoop();
            DoWhileLoop();

            string[] fruits = new String[3] { "apple", "banana", "kiwi" };
            foreach (var fruit in fruits)
            {
                // fruit = "strawberry";  // foreach variable is read-only and cannot be assigned a new value
                Console.WriteLine(fruit);
            }


            Console.ReadLine();

        }

        private static void DoWhileLoop()
        {
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;

            } while (number >= 11);
        }

        private static void WhileLoop()
        {
            int number = 100;
            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }

            Console.WriteLine("Now number is {0}", number);
        }

        private static void ForLoop()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Finished!!!");

            for (int i = 1; i <= 100; i = i + 2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Finished!!!");

            for (int i = 0; i <= 100; i = i + 2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Finished!!!");

            for (int i = 100; i >= 0; i = i - 2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Finished!!!");
        }
    }
}