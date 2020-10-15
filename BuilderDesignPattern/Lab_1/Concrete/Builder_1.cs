using BuilderDesignPattern.Lab_1.Abstraction;
using BuilderDesignPattern.Lab_1.Delegate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern.Lab_1.Concrete
{
    public class Builder_1 : IBuilder
    {
        private Product product = new Product();

        public void BuilderPartA()
        {
            product.Add("Part A");
        }

        public void BuilderPartB()
        {
            product.Add("Bart B");
        }

        public Product GetResult()
        {
            return product;
        }

    }
}
