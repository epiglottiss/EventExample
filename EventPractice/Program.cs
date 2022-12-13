using System;

namespace EventPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var pub = new Publisher();
            var sub1 = new Subscriber(pub);

            pub.TrigEvent();

            Console.ReadLine();
        }
    }
}
