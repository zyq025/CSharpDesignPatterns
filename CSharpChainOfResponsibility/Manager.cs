using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpChainOfResponsibility
{
    /// <summary>
    /// 项目经理
    /// </summary>
    public class Manager : Approver
    {
        public Manager(string name) : base(name)
        {
        }

        public override void ProcessRequest(PurchaseRequest request)
        {
            if (request.Amount < 10000.0)
            {
                Console.WriteLine($"{this}-{Name} approved the request of purshing{request.ProductName}");
            }
            else if (NextProver != null)
            {
                NextProver.ProcessRequest(request);
            }
        }
    }
}
