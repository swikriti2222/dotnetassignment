using System;

namespace MultiDimensionalArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers =
            {
                {10, 20, 30},
                {40, 50, 60}
            };

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.Write(numbers[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}