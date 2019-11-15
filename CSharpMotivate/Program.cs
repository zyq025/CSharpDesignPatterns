using System;
using System.Collections;

namespace CSharpMotivate
{
    /// <summary>
    /// 解释器模式：给定一个语言，定义它的文法的一种表示，并定义一个解释器，这个解释器使用该表示来解释语言中的句子
    /// 举例：解析数字
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string roman = "五千四百三十二";//5432
            Context context = new Context(roman);

            //创建解析树
            ArrayList tree = new ArrayList();
            tree.Add(new OneExpression());
            tree.Add(new TenExpression());
            tree.Add(new HundredExpression());
            tree.Add(new ThousandExpression());

            foreach(Expression exp in tree)
            {
                exp.Interpret(context);
            }
            Console.WriteLine($"{roman}={context.Data}");

        }
    }
}
