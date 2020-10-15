using FactoryMethodPattern.Lab_2.Abstraction;
using FactoryMethodPattern.Lab_2.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Lab_2.Creator
{
    public class SystemManger
    {
        private ILoggerFactory _loggerFactor;
        //Burada bir factory'e bağımlı kalmadan injection ederek işlemleri halletim. DIP prensibi gereği...
        public SystemManger(ILoggerFactory loggerFactory)
        {
            _loggerFactor = loggerFactory;
        }

        public void Save()
        {
            Console.WriteLine("Saved..!");

            ILogger logger_1 = new SystemLoggerFactory().CreateLogger();
            ILogger logger_2 = new PLSLoggerFactory().CreateLogger();

            logger_1.Log();
            logger_2.Log();

            //Bu tarz instance alsaydık SystemLoggerFactory'e tam bağımlı kalacaktık ve SOLID prensiplerinden DIP'e ters düşecektik.
            //ILogger loger = new SystemLoggerFactory();
            //logger_1.CreateLogger();
        }
    }
