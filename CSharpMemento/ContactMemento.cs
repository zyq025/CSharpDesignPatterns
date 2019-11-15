using System.Collections.Generic;

namespace CSharpMemento
{
    public class ContactMemento
    {
        public List<ContactPerson> contactPersonBack;
        

        public ContactMemento(List<ContactPerson> list)
        {
            this.contactPersonBack = list;
        }
    }
}