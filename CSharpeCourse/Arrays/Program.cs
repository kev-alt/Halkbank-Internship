using System.Collections.Generic;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string cow1 = "Sarıkız";
            string cow2 = "Selena";
            string cow3 = "Moona Lisa";

            string[] cows = new string[3];
            cows[0] = cow1;
            cows[1] = cow2;
            cows[2] = "Moona Lisa";

            foreach (var cow in cows) // Loop through each item in cows; cow represents the current item.
            {
                Console.WriteLine(cow);
            }

            string[] peaople = new[] { "Kevser", "Esma", "Salih", "Emine", "Ahmet" };

            foreach (var person in peaople)
            {
                Console.WriteLine(person);
            }

            string[,] regions = new string[7, 3]
            {
                {"İstanbul", "Bursa", "Edirne"},
                {"Ankara", "Konya", "Kırıkkale"},
                {"Antalya", "Adana", "Mersin"},
                {"Rize", "Trabzon", "Samsun"},
                {"İzmir", "Aydın", "Manisa"},
                {"Malatya", "Erzurum", "Van"},
                {"Gaziantep", "Şanlıurfa", "Diyarbakır"},
            };

            for (int i = 0; i < regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
                Console.WriteLine("********");
            }



            Console.WriteLine();
            Console.ReadLine();
        }
    }
}