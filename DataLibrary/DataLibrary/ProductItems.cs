﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public class ProductItems
    {
         public ProductItems()
        {
            // empty constructor
        }
        public int SubCategoryId { get; set; }
        public int ProductId { get; set; }
        public double Price { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }        
    }
}
