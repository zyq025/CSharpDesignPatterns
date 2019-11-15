using System;
using System.Collections.Generic;

namespace CSharpMemento
{
    /// <summary>
    /// 备忘录模式：在不破坏封装的前提下，捕获一个对象的内部状态，并在该对象之外保存这个状态，这样以后就可以吧该对象恢复到原先的状态
    /// 发起人角色：记录当前时刻的内部状态，负责创建和恢复备忘录数据
    /// 备忘录角色：负责存储发起人对象的内部状态，在进行恢复时提供给发起人需要的状态
    /// 管理者角色：负责保存备忘录对象。
    /// 举例： 手机通讯录
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            List<ContactPerson> persons = new List<ContactPerson>
            {
                new ContactPerson(){Name="Learning Hard",MobileNum="123445"},
                new ContactPerson(){Name="Tony",MobileNum="234556"},
                new ContactPerson(){Name="Jock",MobileNum="231445"}
            };
            MobileOwner mobileOwner = new MobileOwner(persons);
            mobileOwner.Show();

            //创建备忘录并保存备忘录对象
            Caretaker caretaker = new Caretaker();
            caretaker.ContactM = mobileOwner.CreateMemento();

            // 更改发起人联系人列表
            Console.WriteLine("=========移除最后一个联系人==========");
            mobileOwner.ContactPersons.RemoveAt(2);
            mobileOwner.Show();

            //恢复到原始状态
            Console.WriteLine("===========恢复联系人列表==========");
            mobileOwner.RestoreMemento(caretaker.ContactM);
            mobileOwner.Show();
        }
    }
}
