using FactoryMethodPattern.Lab_1.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Lab_1.Concrete
{
    public class DefaultProduct:IProduct
    {
        public string ShipFrom()
        {
            return "not avaliable";
        }
    }
}
