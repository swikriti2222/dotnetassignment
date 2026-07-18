using System;

namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 20, 30, 40, 50 };

            Console.WriteLine("Array Elements:");

            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("First Element: " + numbers[0]);
            Console.WriteLine("Array Length: " + numbers.Length);
        }
    }
}


