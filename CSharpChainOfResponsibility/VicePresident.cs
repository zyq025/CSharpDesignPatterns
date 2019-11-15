using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpChainOfResponsibility
{
    /// <summary>
    /// 副总
    /// </summary>
    public class VicePresident : Approver
    {
        public VicePresident(string name) : base(name)
        {
        }

        public override void ProcessRequest(PurchaseRequest request)
        {
            if (request.Amount < 25000.0)
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
