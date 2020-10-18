using DecoratorDesignPattern.Lab_1.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern.Lab_1.Concrete
{
    public class Decorator_A : IBilesen
    {
        IBilesen _bilesen;

        public Decorator_A(IBilesen bilesen)
        {
            _bilesen = bilesen;
        }

        public string Operasyon()
        {
            string s = _bilesen.Operasyon();
            s += "yazılım tanımlı ağlar ile ";
            return s;
        }
    }
}
