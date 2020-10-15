using BridgeDesignPattern.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern.Concrete
{
    public class Uygulama_A : IKopru
    {
        public string OperasyonUygulaması()
        {
            return "Uygulama A";
        }
    }
}
