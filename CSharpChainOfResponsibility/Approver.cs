using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpChainOfResponsibility
{
    /// <summary>
    /// 抽象审批者  Handler
    /// </summary>
    public abstract class Approver
    {
        /// <summary>
        /// 下一个审批者
        /// </summary>
        public Approver NextProver { get; set; }

        /// <summary>
        /// 审批者姓名
        /// </summary>
        public string Name { get; set; }

        public Approver(string name)
        {
            this.Name = name;
        }

        public abstract void ProcessRequest(PurchaseRequest request);
    }
}
