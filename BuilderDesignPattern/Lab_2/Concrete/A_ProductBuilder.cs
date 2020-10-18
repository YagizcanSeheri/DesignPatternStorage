﻿using BuilderDesignPattern.Lab_2.Abstraction;
using BuilderDesignPattern.Lab_2.Delegate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern.Lab_2.Concrete
{
    public class A_ProductBuilder:ProductBuilder
    {
        ProductModel model = new ProductModel();
        public override void ApplyDiscount()
        {
            model.DiscountPrice = model.UnitPrice * (decimal)0.90;
            model.DiscountedApplied = true;
        }

        public override ProductModel GetModel()
        {
            return model;
        }

        public override void GetProductData()
        {
            model.Id = 1;
            model.ProductName = "Hamsi";
            model.UnitPrice = 20;
        }
    }
}
