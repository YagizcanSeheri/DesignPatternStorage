using DecoratorDesignPattern.Lab_1.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern.Lab_1.Concrete
{
    public class Decorator_B : IBilesen
    {
        IBilesen _bilesen;

        public Decorator_B(IBilesen bilesen)
        {
            _bilesen = bilesen;
        }

        public string Operasyon()
        {
            string s = _bilesen.Operasyon();
            s += "ve bazı IoT süreçleri yönetiyorum.";
            return s;
        }

        public string EklenenDavranis()
        {
            return "Ayrıca yüksek lisans yapıyorum.";
        }
    }
}
