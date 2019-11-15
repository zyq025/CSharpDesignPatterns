using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CSharpMediator
{
    /// <summary>
    /// Concrete Mediator
    /// </summary>
    public class Chatroom : AbstactChatroom
    {
        private Hashtable participants = new Hashtable();

        public override void Register(Participant participant)
        {
            if(participants[participant.Name]==null)
            {
                participants[participant.Name] = participant;
            }
            participant.Chatroom = this;
        }

        public override void Send(string from, string to, string message)
        {
            Participant pto = participants[to] as Participant;
            if (pto != null)
            {
                pto.Receive(from, message);
            }
        }
    }
}
