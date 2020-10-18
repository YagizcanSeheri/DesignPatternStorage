using MediatorDesignPattern.Lab_2.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern.Lab_2.Concrete
{
    public class BasicUser : IUser
    {
        string _name;
        IChatMediator _chatMediator;

        public BasicUser(IChatMediator chatMediator, string name)
        {
            this._name = name;
            this._chatMediator = chatMediator;
        }

        public void ReceiveMessage(string message)
        {
            Console.WriteLine($"Kullanıcı Tipi: Basic\nKullanıcı Adı: {_name}\nAlınan Mesaj: {message}");
        }

        public void SendMessage(string message)
        {
            _chatMediator.SendMessage(message, this);
        }
    }
}
