using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProductsAndCategories.Models
{
    public class Association
    {
        public int AssociationId {get; set;}

        [Display(Name="Product")]
        public int ProductId {get; set;}
        public int CategoryId {get; set;}
        public Product Product {get; set;}
        public Category Category {get; set;}
       
    }
}