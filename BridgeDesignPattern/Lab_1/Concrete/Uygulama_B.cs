using BridgeDesignPattern.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern.Concrete
{
    public class Uygulama_B : IKopru
    {
        public string OperasyonUygulaması()
        {
            return "Uygulama B";
        }
    }
}
