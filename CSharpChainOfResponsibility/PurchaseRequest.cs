using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpChainOfResponsibility
{
    /// <summary>
    /// 采购请求
    /// </summary>
    public class PurchaseRequest
    {
        /// <summary>
        /// 金额
        /// </summary>
        public double Amount { get; set; }

        /// <summary>
        /// 产品名字
        /// </summary>
        public string ProductName { get; set; }

        public PurchaseRequest(double amount, string productName)
        {
            Amount = amount;
            ProductName = productName;
        }
    }
}
