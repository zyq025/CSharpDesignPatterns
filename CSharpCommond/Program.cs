using System;

namespace CSharpCommond
{
    /// <summary>
    /// 命令模式：将一个请求封装为一个对象，从而使你可用不同的请求对客户进行参数化；对请求排队或记录请求日志，以及致辞可撤销的操作
    /// 客户角色：发出一个具体的命令并确定其接受者
    /// 命令角色：声明了一个给所有具体命令类实现的抽象接口
    /// 具体命令角色：定义了一个接受者和行为的弱耦合，负责调用接受者的相应方法
    /// 请求者角色：负责调用命令对象执行命令
    /// 接受者角色：负责具体行为的执行
    /// 举例：院领导要求学生军训，院领导发出命令，教官负责调用命令对象执行请求，学生负责执行具体命令，比如跑1000米等
    /// </summary>
    class Program
    {
        /// <summary>
        /// 充当院领导角色
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //指定执行对象
            Receiver r = new Receiver();
            //指定要做什么
            Commond c = new ConcreteCommand(r);
            //指定命令转发者
            Invoke i = new Invoke(c);

            //发出命令
            i.ExecuteCommand();
        }
    }
}
