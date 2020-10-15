using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern.Lab_2.Abstraction
{
    public abstract class MailSenderBase
    {
        public void Save()
        {
            Console.WriteLine("Message saved..!");
        }

        public abstract void Send(MailStructure mailStructure);
    }
}
