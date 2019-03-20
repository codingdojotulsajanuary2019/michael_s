using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProductsAndCategories.Models
{
    public class ViewModel
    {
        public Product NewProduct;
        public Product ViewProduct;
        public Category NewCategory;
        public Category ViewCategory;
        public Association NewAssociation;

        public List<Product> AllProducts;
        public List<Category> AllCategories;


       
    }
}