using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)// main entrance to the application:
        {
            Console.WriteLine("Hello, World!");

            long bigNumber = 90000000L;
            Console.WriteLine(bigNumber);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);

            double negative = -55.6D;
            Console.WriteLine(negative);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);
            
            char defaultvar = '\0';// this is the default character

            Console.WriteLine("This terminates at the end of the line.");
    
            // Console.Write("Enter any character or string ");
            // string chara = Console.ReadLine();
            // Console.Write("Enter your age: ");
            // int age = int.Parse(Console.ReadLine());
            // // double age1 = double.Parse(Console.ReadLine());
            // Console.WriteLine(chara);
            // Console.WriteLine(age);

            Console.Write("Enter day:");
            // Int16 day = Int16.Parse(Console.ReadLine());
            Int16 day = 3;
            
            switch (day)
            {
                case 1: Console.WriteLine("Monday"); break;
                case 2: Console.WriteLine("Tuesday"); break;
                case 3: Console.WriteLine("Wednesday"); break;
                case 4: Console.WriteLine("Thursday"); break;
                case 5: Console.WriteLine("Friday"); break;
                case 6: Console.WriteLine("Saturday"); break;
                case 7: Console.WriteLine("Sunday"); break;
            }

            double num = 40D / 3D;

            Console.WriteLine(num);
            Console.WriteLine(string.Format("{0:0.#}", num));
            Console.WriteLine(string.Format("{0:0.0}", num));
            Console.WriteLine(string.Format("{0:0.00}", num));
            
            int[] arr = new int[3] { 1, 2, 3 };
            PrintArray(arr);
            Console.WriteLine(Add(3, 4));

            Console.WriteLine(Anagram.IsAnagram("aabab", "bbaaa"));
            
            int[] list = new int[5] { 3, 4, 1, 0, 2};
            PrintArray(list);
            BubbleSort.Sort(list);
            PrintArray(list);
        }

        static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }

        static int Add(int a, int b = default)
        {
            return a + b;
        }
    }
}
