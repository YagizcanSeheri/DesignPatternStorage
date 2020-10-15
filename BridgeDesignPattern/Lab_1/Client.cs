using BridgeDesignPattern.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
    public class Client
    {
        IKopru _kopru;
        public Client(IKopru kopru)
        {
            _kopru = kopru;
        }

        public string Operasyon()
        {
            return "Soyutlama " + "==Koprü==" + _kopru.OperasyonUygulaması();
        }
    }
}
