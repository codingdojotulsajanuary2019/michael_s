using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProductsAndCategories.Models
{
    public class Product
    {
      
        public int ProductId {get; set;}
        public string Name {get; set;}
        public string Description {get; set;}
        public Decimal Price {get; set;}
        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public DateTime UpdatedAt {get; set;} = DateTime.Now;

        public List<Association> ProductCategories {get; set;}
    }
}