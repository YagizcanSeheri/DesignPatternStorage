﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern.Abstraction
{
    public class Uyarlayici
    {
        public double SpesifikIstek(double a, double b)
        {
            return a / b;
        }
    }
}
