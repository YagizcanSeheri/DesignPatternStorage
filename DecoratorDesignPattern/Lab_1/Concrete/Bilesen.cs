using DecoratorDesignPattern.Lab_1.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern.Lab_1.Concrete
{

        public class Bilesen : IBilesen
        {
            public string Operasyon()
            {
                return "Çalıtığım firma için ";
            }
        }

}
