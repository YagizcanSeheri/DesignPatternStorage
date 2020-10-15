using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Lab_2.Abstraction
{
    public interface ILoggerFactory
    {
        ILogger CreateLogger();
    }
}
