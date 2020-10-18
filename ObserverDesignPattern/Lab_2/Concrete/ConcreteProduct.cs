using ObserverDesignPattern.Lab_2.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern.Lab_2.Concrete
{
    public class ConcreteProduct : Product
    {
        public ConcreteProduct(string productName, decimal unitPrice) : base(productName, unitPrice)
        {

        }
    }
}
