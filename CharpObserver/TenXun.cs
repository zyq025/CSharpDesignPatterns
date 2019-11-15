using System;
using System.Collections.Generic;
using System.Text;

namespace CharpObserver
{
    /// <summary>
    /// 订阅号抽象类
    /// </summary>
    public abstract class TenXun
    {
        /// <summary>
        /// 保存订阅者列表
        /// </summary>
        private List<IObserver> observers = new List<IObserver>();

        public string Symbol { get; set; }
        public string Info { get; set; }

        public TenXun(string symbol,string info)
        {
            this.Symbol = symbol;
            this.Info = info;
        }

        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);

        }

        public void Update()
        {
            foreach(IObserver observer in observers)
            {
                if(observer!=null)
                {
                    observer.ReceiveAndPrint(this);
                }
            }
        }
    }
}
