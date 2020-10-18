using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern.Lab_2.Abstraction
{
    public interface IChatMediator
    {
        void AddUser(IUser user);
        void SendMessage(string message, IUser sender);
    }
}
