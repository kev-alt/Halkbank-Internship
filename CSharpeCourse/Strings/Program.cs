using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro();

            string sentence = "My nickname is 'ben1inegim.'";

            var result = sentence.Length;   
            var result2 = sentence.Clone();

            sentence = "My name is Kevser.";

            bool result3 = sentence.EndsWith("m");    
            bool result4 = sentence.StartsWith("a");  
            var result5 = sentence.IndexOf("is");
            var result6 = sentence.IndexOf("ş");
            var result7 = sentence.IndexOf(" ");
            var result8 = sentence.LastIndexOf(" ");
            var result9 = sentence.Insert(0, "Hello, ");
            var result10 = sentence.Substring(3);
            var result11 = sentence.Substring(4,8);
            var result12 = sentence.ToLower();
            var result13 = sentence.ToUpper();
            var result14 = sentence.Replace(" ","-");
            var result15 = sentence.Remove(2);
            var result16 = sentence.Remove(3, 11);


            Console.WriteLine("Length: " + result);
            Console.WriteLine("Clone: " + result2);
            Console.WriteLine("EndsWith 'm': " + result3);
            Console.WriteLine("StartsWith 'a': " + result4);
            Console.WriteLine("IndexOf 'is': " + result5);
            Console.WriteLine("IndexOf 'ş': " + result6);
            Console.WriteLine("IndexOf ' ': " + result7);
            Console.WriteLine("IndexOf ' ': " + result8);
            Console.WriteLine(result9);
            Console.WriteLine(result10);
            Console.WriteLine(result11);
            Console.WriteLine(result12);
            Console.WriteLine(result13);
            Console.WriteLine(result14);
            Console.WriteLine(result15); 
            Console.WriteLine(result16);

            Console.ReadLine();
        }

        private static void Intro()
        {
            string city = "İstanbul";
            Console.WriteLine("City: " + city);
            Console.WriteLine("First letter: " + city[0]);

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "Malatya";
            string result = city + city2;

            Console.WriteLine("Concatenated: " + result);
            Console.WriteLine(string.Format("{0} {1}", city, city2));
        }
    }
}