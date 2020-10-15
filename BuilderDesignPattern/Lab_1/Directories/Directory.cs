using BuilderDesignPattern.Lab_1.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern.Lab_1.Directories
{
    public class Directory
    {
        public void Constructor(IBuilder builder)
        {
            builder.BuilderPartA();
            builder.BuilderPartB();

            builder.BuilderPartB();
            builder.BuilderPartA();
        }
    }
}
