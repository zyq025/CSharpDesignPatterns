using System;

namespace CSharpMediator
{
    /// <summary>
    /// 中介者模式: 用一个中介对象来封装一系列对象交互。中介者使各对象不需要相互引用。从而使其耦合松散，而且可以独立地改变他之间的交互。
    /// 举例：生活中QQ聊天，QQ就充当了人与人之间的中介，不用事事都需要面对面交流
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //Create chatroom
            Chatroom chatroom = new Chatroom();
            //Create participants and register them

            Participant George = new Beatle("George");
            Participant Paul = new Beatle("Paul");
            Participant Ringo = new Beatle("Ringo ");
            Participant John = new Beatle("John");
            Participant Yoko = new Beatle("Yoko");

            chatroom.Register(George);
            chatroom.Register(Paul);
            chatroom.Register(Ringo);
            chatroom.Register(John);
            chatroom.Register(Yoko);

            Yoko.Send("John", "Hi John");
            Paul.Send("Ringo", "All you need is love");
            Ringo.Send("George", "My sweet Lord");
            Paul.Send("John", "Can't buy me love");
            John.Send("Yoko", "My sweet love");
        }
    }
}
