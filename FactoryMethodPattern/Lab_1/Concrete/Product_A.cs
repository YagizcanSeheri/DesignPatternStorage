using FactoryMethodPattern.Lab_1.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Lab_1.Concrete
{
    public class Product_A:IProduct
    {
        public string ShipFrom()
        {
            return "from South Africa";
        }
    }
}
