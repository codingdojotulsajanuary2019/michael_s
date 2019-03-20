using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProductsAndCategories.Models
{
    public class Category
    {
        public int CategoryId {get; set;}
        public string Name {get; set;}
        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public DateTime UpdatedAt {get; set;} = DateTime.Now;

        public List<Association> CategoryProducts {get; set;}

    }
}