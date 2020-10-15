using FactoryMethodPattern.Lab_2.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Lab_2.Concrete
{
    public class SystemLoggerFactory : ILoggerFactory
    {
        //temel bir methot vasıtasıyla logger üreteceğiz ve üreteceğimiz logger sistemsel log olacaktır
        public ILogger CreateLogger()
        {
            //burda bir iş geliştirilip, bu geliştirilen sürecin ne yapacağına karar verilir
            return new SystemLogger();
        }
    }
}
