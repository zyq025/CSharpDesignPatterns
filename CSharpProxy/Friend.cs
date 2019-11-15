using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProxy
{
    /// <summary>
    /// 代理角色
    /// </summary>
    public class Friend : Person
    {
        /// <summary>
        /// 引用真实主题实例
        /// </summary>
        RealBuyPerson realBuyPerson;

        public override void BuyProduct()
        {
            Console.WriteLine("通过代理类访问这是实体对象的方法");
            if(realBuyPerson==null)
            {
                realBuyPerson = new RealBuyPerson();
            }
            this.PreBuyProduct();
            realBuyPerson.BuyProduct();
            this.PosBuyProduct();
        }

        #region 代理角色的一些操作

        /// <summary>
        /// 帮的人有点多，需要列一份清单
        /// </summary>
        public void PreBuyProduct()
        {

            Console.WriteLine("我怕弄糊涂了，需要列一张清单，张三：要带相机，李四：要带IPhone....");
        }

        /// <summary>
        /// 买完东西之后，代理角色需要针对每位朋友需要的东西进行分类
        /// </summary>
        public void PosBuyProduct()
        {
            Console.WriteLine("终于买完了，将东西分一下，相机是张三的；IPhone是李四的......");

        } 
        #endregion
    }
}
