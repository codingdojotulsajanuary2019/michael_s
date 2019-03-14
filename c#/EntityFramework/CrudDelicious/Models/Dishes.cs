using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace CrudDelicious.Models
{
    public class Dish
    {
        [Key]
        public int DishID {get; set;}

        [Required(ErrorMessage="Field cannot be empty")]
        [Display(Name="Name of Dish:")]
        public string Name {get; set;}


        [Required(ErrorMessage="Field cannot be empty")]
        [Display(Name="Chef's Name:")]
        public string Chef {get; set;}

        [Display(Name="Tastiness:")]
        public int Tastiness {get; set;}

        [Required(ErrorMessage="Field cannot be empty")]
        [Display(Name="# of Calories:")]
        public int Calories {get; set;}

        [Required(ErrorMessage="Field cannot be empty")]
        [Display(Name="Description:")]
        public string Description {get; set;}
        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public DateTime UpdatedAt{get; set;} = DateTime.Now;

       
    }

    public class AllDishes 
    {
        public List<Dish> alldishes {get; set;}

    }

}