namespace CSharpVistor
{
    public interface IVisitor
    {
        void Visit(ElementA elementA);
        void Visit(ElementB elementB);
    }
}