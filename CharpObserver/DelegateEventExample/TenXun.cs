using System;
using System.Collections.Generic;
using System.Text;

namespace CharpObserver.DelegateEventExample
{
    public delegate void NotifyEventHandler(object sender);
    public class TenXun
    {
        public NotifyEventHandler NotifyEvent;

        public string Symbol { get; set; }
        public string Info { get; set; }

        public TenXun(string symbol, string info)
        {
            this.Symbol = symbol;
            this.Info = info;
        }

        public void AddObserver(NotifyEventHandler ob)
        {
            NotifyEvent+= ob;
        }

        public void RemoveObserver(NotifyEventHandler ob)
        {
            NotifyEvent-=ob;

        }

        public void Update()
        {
           if(NotifyEvent!=null)
            {
                NotifyEvent(this);
            }
        }
    }
}
