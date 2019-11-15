using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpMediator
{
    /// <summary>
    /// Mediator
    /// </summary>
    public abstract class AbstactChatroom
    {
        public abstract void Register(Participant participant);
        public abstract void Send(string from, string to, string message);
    }
}
