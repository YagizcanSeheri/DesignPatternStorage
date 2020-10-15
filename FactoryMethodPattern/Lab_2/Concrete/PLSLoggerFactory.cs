using FactoryMethodPattern.Lab_2.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Lab_2.Concrete
{
    public class PLSLoggerFactory : ILoggerFactory
    {
        public ILogger CreateLogger()
        {
            return new PLSLogger();
        }
    }
}
