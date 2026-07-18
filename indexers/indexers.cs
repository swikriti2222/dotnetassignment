using System;

namespace dotnetassignments
{
    class Student
    {
        private string[] names = new string[3];

        // Indexer
        public string this[int index]
        {
            get { return names[index]; }
            set { names[index] = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- INDEXER DEMO -----");

            Student student = new Student();

            student[0] = "Swikriti";
            student[1] = "Hari";
            student[2] = "Sita";

            Console.WriteLine("Student Names:");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(student[i]);
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}