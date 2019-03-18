using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using ChefsDishes.Models;

namespace ChefsDishes
{
    public class Dish
    {
        [Key]
        public int DishId {get;set;}
        

        [Required(ErrorMessage="Field is required")]
        [Display(Name="Name of Dish")]
        public string Name {get;set;}

        [Required (ErrorMessage="Field is required")]
        public int? Calories {get;set;}

        [Required (ErrorMessage="Field is required")]
        public int? Tastiness {get;set;}

        [Required (ErrorMessage="Field is required")]
        public string Description {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
        
        public int ChefId {get; set;}


        public Chef Creator {get;set;}


    }
}