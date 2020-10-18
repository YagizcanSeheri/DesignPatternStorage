using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern.Lab_2.Abstraction
{
    public abstract class CarDecortorBase : CarBase
    {
        private CarBase _carBase;

        public CarDecortorBase(CarBase carBase)
        {
            _carBase = carBase;

        }
    }
}
