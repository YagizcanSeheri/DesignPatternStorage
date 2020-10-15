using FactoryMethodPattern.Lab_2.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Lab_2.Concrete
{
    public class PLSLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Motors PLS was logger..!");
        }
    }
}
