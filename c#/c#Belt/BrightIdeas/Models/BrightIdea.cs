using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace BrightIdeas.Models
{
    public class BrightIdea
    {
        [Key]
        public int IdeaId {get; set;}


        [Required(ErrorMessage="Idea Cannot Be Empty")]
        [MinLength(5, ErrorMessage="Idea Must be 5 Characters Long")]
        [Display(Name="Create New Idea")]
        public string Idea {get; set;}
        public DateTime CreatedAt{get; set;} = DateTime.Now;
        public DateTime UpdatedAt{get; set;} = DateTime.Now;
        public int UserId {get; set;}

        public User Creator {get;set;}

        public List<Like> Likes {get; set;}



    }
}