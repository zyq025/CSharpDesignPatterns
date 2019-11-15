namespace CSharpIterator
{
    internal class ConcreteIterator : IIterator
    {
        private ConcreteList concreteList;
        private int index ;

        public ConcreteIterator(ConcreteList concreteList)
        {
            this.concreteList = concreteList;
            index = 0;
        }

        public object CurrentItem()
        {
            return concreteList.GetElement(index);
        }

        public void First()
        {
            index=0;
        }

        public bool MoveNext()
        {
            if(index<concreteList.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Next()
        {
            if(index<concreteList.Length)
            {
                index++;
            }
        }
    }
}