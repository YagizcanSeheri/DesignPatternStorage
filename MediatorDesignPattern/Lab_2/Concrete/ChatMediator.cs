using MediatorDesignPattern.Lab_2.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern.Lab_2.Concrete
{
    public class ChatMediator : IChatMediator
    {
        List<IUser> users;

        public ChatMediator()
        {
            users = new List<IUser>();
        }

        public void AddUser(IUser user)
        {
            users.Add(user);
        }

        public void SendMessage(string message, IUser sender)
        {
            foreach (IUser user in users)
            {
                if (user != sender)
                {
                    user.ReceiveMessage(message);
                }
            }
        }
    }
}
