using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTemplateMethod
{
    /// <summary>
    /// 模板类
    /// </summary>
    public abstract class Vegetable
    {
        /// <summary>
        /// 模板方法，不要把模板方法定义为Virtaul或abstract方法，避免被子类重写，防止更改流程的执行顺序
        /// </summary>
        public void CookVegetable()
        {
            Console.WriteLine("炒蔬菜的一般做法");
            this.PourOil();
            this.HeatOil();
            this.PourVegetable();
            this.stir_fry();
        }

        /// <summary>
        /// 炒菜第一步倒油
        /// </summary>
        public void PourOil()
        {
            Console.WriteLine("倒油");
        }

        /// <summary>
        /// 第二步烧油
        /// </summary>
        public void HeatOil()
        {
            Console.WriteLine("烧油");
        }

        /// <summary>
        /// 第三步，倒入蔬菜，具体是哪种蔬菜不知道，子类实现
        /// </summary>
        public abstract void PourVegetable();

        /// <summary>
        /// 第三步翻炒
        /// </summary>
        public void stir_fry()
        {
            Console.WriteLine("翻炒");
        }
    }
}
