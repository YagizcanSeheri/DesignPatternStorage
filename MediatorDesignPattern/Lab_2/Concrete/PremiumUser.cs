using MediatorDesignPattern.Lab_2.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern.Lab_2.Concrete
{
    public class PremiumUser : IUser
    {
        string _name;
        IChatMediator _chatMediator;

        public PremiumUser(IChatMediator chatMediator, string name)
        {
            this._chatMediator = chatMediator;
            this._name = name;
        }

        public void ReceiveMessage(string message)
        {
            Console.WriteLine($"KUllanıcı Tipi: Premeium\nKullanıcı Adi: {_name}\nAlınan Mesaj: {message}");
        }

        public void SendMessage(string message)
        {
            _chatMediator.SendMessage(message, this);
        }
    }
}
