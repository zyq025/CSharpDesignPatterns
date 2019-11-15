using System;
using System.Collections.Generic;
using System.Text;

namespace CharpObserver.DelegateEventExample
{
    /// <summary>
    /// 具体订阅类
    /// </summary>
    public class Subscriber
    {
        public string Name { get; set; }

        public Subscriber(string name)
        {
            Name = name;
        }

        public void ReceiveAndPrint(Object obj)
        {
            TenXun tenXun = obj as TenXun;
            if(tenXun!=null)
            {
                Console.WriteLine($"Notified {Name} of {tenXun.Symbol}'s Info is :{tenXun.Info}");
            }
        }
    }
}
