using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace ChefsDishes.Models
{
    public class Chef
    {
        [Key]
        public int ChefId {get; set;}

        [Required(ErrorMessage = "Field Cannot Empty")]
        [Display(Name = "First Name")]
        public string FirstName {get; set;}

    
        [Required(ErrorMessage = "Field Cannot Empty")]
        [Display(Name = "Last Name")]
        public string LastName {get; set;}


        [Required(ErrorMessage = "Field Cannot Empty")]
        [Display(Name = "Birthday")]
        public DateTime DOB {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        public List<Dish> ChefsDishes {get;set;}

    }

    public class ViewModel
    {
        public List <Chef> AllChefs {get; set;}
        public List <Dish> AllDishes {get; set;}
        public Dish ThisDish {get; set;} 
    }
}