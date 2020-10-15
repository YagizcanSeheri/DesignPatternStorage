using BridgeDesignPattern.Lab_2.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern.Lab_2.Concrete
{
    public class GmailSender : MailSenderBase
    {
        public override void Send(MailStructure mailStructure)
        {
            Console.WriteLine(string.Format("Title: {0}\nText: {1}\nDescription: Mail send from gmail", mailStructure.Title, mailStructure.Text));
        }
    }
}
