using System;

namespace dotnetassignments
{
    class Publisher
    {
        public delegate void Notify();

        public event Notify ProcessCompleted;

        public void StartProcess()
        {
            Console.WriteLine("Process Started...");

            if (ProcessCompleted != null)
                ProcessCompleted();
        }
    }

    class Subscriber
    {
        public void Message()
        {
            Console.WriteLine("Event Received: Process Completed");
        }
    }

    class EventDemo
    {
        public static void Run()
        {
            Console.WriteLine("----- EVENT -----");

            Publisher p = new Publisher();
            Subscriber s = new Subscriber();

            p.ProcessCompleted += s.Message;

            p.StartProcess();
        }
    }

    class @Event
    {
        static void Main(string[] args)
        {
            EventDemo.Run();
        }
    }
}