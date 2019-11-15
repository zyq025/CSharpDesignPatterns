using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpMemento
{
    /// <summary>
    /// 发起人
    /// </summary>
    public class MobileOwner
    {
        /// <summary>
        /// 发起人要保存的内部状态
        /// </summary>
        public List<ContactPerson> ContactPersons { get; set; }

        public MobileOwner(List<ContactPerson> persons)
        {
            ContactPersons = persons;
        }

        /// <summary>
        /// 创建备忘录，将当时要保存的联系人列表导入到备忘录中
        /// </summary>
        /// <returns></returns>
        public ContactMemento CreateMemento()
        {
            // 这里也应该传递深拷贝，new List方式传递的是浅拷贝，
            // 因为ContactPerson类中都是string类型,所以这里new list方式对ContactPerson对象执行了深拷贝
            // 如果ContactPerson包括非string的引用类型就会有问题，所以这里也应该用序列化传递深拷贝
            return new ContactMemento(new List<ContactPerson>(this.ContactPersons));
        }

        /// <summary>
        /// 将备忘录中的数据备份导入到联系人列表中
        /// </summary>
        /// <param name="memento"></param>
        public void RestoreMemento(ContactMemento memento)
        {
            this.ContactPersons = memento.contactPersonBack;
        }

        public void Show()
        {
            Console.WriteLine($"联系人列表中有{ContactPersons.Count},他们是:");
            foreach(ContactPerson p in ContactPersons)
            {
                Console.WriteLine($"姓名:{p.Name} 号码为:{p.MobileNum}");
            }
        }

    }
}
