using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpSampleFactory
{
    /// <summary>
    /// 简单工厂 案例接口
    /// </summary>
    public interface IAutoCarMake
    {
        /// <summary>
        /// 制造汽车
        /// </summary>
        void MakeAutoCar();
    }
}
