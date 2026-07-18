using System;

namespace dotnetassignments
{
    class DelegateDemo
    {
        public delegate void Display();

        public static void Message()
        {
            Console.WriteLine("Hello from Delegate");
        }

        public static void Run()
        {
            Console.WriteLine("----- DELEGATE -----");

            Display d = Message;
            d();

            Console.WriteLine();
        }
    }

    class @Delegate
    {
        static void Main(string[] args)
        {
            DelegateDemo.Run();
        }
    }
}