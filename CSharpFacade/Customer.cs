using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFacade
{
    /// <summary>
    /// 顾客类
    /// </summary>
    public class Customer
    {
        private string _name;
        public Customer(string name)
        {
            this._name = name;
        }

        public string Name
        {
            get { return _name; }
        }
    }
}
