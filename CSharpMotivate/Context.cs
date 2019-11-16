namespace CSharpInterpreter
{
    /// <summary>
    /// 公共类，定义一些全局信息
    /// </summary>
    public class Context
    {
        private string statement;
        private int data;

        public Context(string statement)
        {
            this.Statement = statement;
        }

        public string Statement { get => statement; set => statement = value; }
        public int Data { get => data; set => data = value; }
    }
}