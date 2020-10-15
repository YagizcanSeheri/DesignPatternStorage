﻿using BuilderDesignPattern.Lab_1.Delegate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern.Lab_1.Abstraction
{
    public interface IBuilder
    {
        void BuilderPartA();
        void BuilderPartB();
        Product GetResult();
    }
}
