using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventPractice
{
    class Subscriber
    {
        public Subscriber(Publisher publisher)
        {
            publisher.timeEvent += HandleEvent1;
        }

        void HandleEvent1(object sender, DataEventArgs e)
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("HandleEvent1 working..");
                Thread.Sleep(1000);
            }
        }
    }
}
