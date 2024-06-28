﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportantInterfaces
{
    public class Product : ICloneable
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public object Clone()
        {
            Product newProduct = new Product();
            newProduct.Name = Name;
            newProduct.Price = Price;
            return newProduct;
        }
    }
}
/*
 * This will copy the existing thing
 */