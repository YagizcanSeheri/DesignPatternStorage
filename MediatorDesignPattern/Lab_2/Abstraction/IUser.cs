using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern.Lab_2.Abstraction
{
    public interface IUser
    {
        void SendMessage(string message);
        void ReceiveMessage(string message);
    }
}
