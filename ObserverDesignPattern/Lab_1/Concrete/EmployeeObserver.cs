using ObserverDesignPattern.Lab_1.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern.Lab_1.Concrete
{
    public class EmployeeObserver : BaseObserver
    {
        public override void Update()
        {
            Console.WriteLine("Message to EMployee: Product was changed..!");
        }
    }
}
