using System;
using System.Collections.Generic;
using System.Text;

namespace CharpObserver
{
    /// <summary>
    /// 具体的订阅者类
    /// </summary>
    public class Subscriber : IObserver
    {
        public string Name { get; set; }
        public Subscriber(string name)
        {
            this.Name = name;
        }
        public void ReceiveAndPrint(TenXun tenXun)
        {
            Console.WriteLine($"Notified {Name} of {tenXun.Symbol}'s Info is:{tenXun.Info}");
        }
    }
}
