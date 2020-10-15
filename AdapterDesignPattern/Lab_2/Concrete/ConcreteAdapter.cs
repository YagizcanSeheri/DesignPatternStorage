using AdapterDesignPattern.Lab_2.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern.Lab_2.Concrete
{

    public class ConcreteAdapter : ITarget
    {
        private readonly Bagdastirici _bagdastirici;

        public ConcreteAdapter(Bagdastirici bagdastirici)
        {
            this._bagdastirici = bagdastirici;
        }

        public string GetRequest()
        {
            return $"This is '{this._bagdastirici.GetSpesificRequest()}'";
        }
    }
}
