using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpChainOfResponsibility
{
    /// <summary>
    /// 总经理
    /// </summary>
    public class President : Approver
    {
        public President(string name) : base(name)
        {
        }

        public override void ProcessRequest(PurchaseRequest request)
        {
            if(request.Amount<100000.0)
            {
                Console.WriteLine($"{this}-{Name} approved the request of purshing{request.ProductName}");
            }
            else
            {
                Console.WriteLine("Request需要开会讨论!!!!");
            }
        }
    }
}
