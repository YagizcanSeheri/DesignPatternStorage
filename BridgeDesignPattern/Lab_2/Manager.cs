using BridgeDesignPattern.Lab_2.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern.Lab_2
{
    public class Manager
    {
        public MailSenderBase MailSenderBase { get; set; }

        public void Info()
        {
            MailSenderBase.Send(new MailStructure { Title = "About the course hours", Text = "Dear Participant,\n Our course hours was changed.\n Sincerely." });
        }
    }
}
