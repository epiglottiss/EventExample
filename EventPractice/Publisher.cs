using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPractice
{
    public class DataEventArgs : EventArgs
    {
        public DataEventArgs(List<string> message)
        {
            Message = message;
        }

        public List<string> Message { get; set; }
    }

    class Publisher
    {
        public event EventHandler<DataEventArgs> timeEvent;
        
        public void TrigEvent()
        {
            var list = new List<string>();
            list.Add("hi");
            list.Add("hello");
            OnRaiseEvent(new DataEventArgs(list));
            Console.WriteLine("first call");
            OnRaiseEvent(new DataEventArgs(list));
            Console.WriteLine("second call");

        }
        private async Task OnRaiseEvent(DataEventArgs e)
        {
            var eventHandler = timeEvent;
            if(timeEvent != null)
            {
                var task = Task.Run(() => eventHandler(this, e));
                Console.WriteLine("Event sent.");
                await task;
            }
            
            Console.WriteLine("OnRaiseEvent end.");
        }
    }
}
