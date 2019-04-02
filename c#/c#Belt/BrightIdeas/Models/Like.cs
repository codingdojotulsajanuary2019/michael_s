using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace BrightIdeas.Models
{
    public class Like
    {
        [Key]
        public int LikeId {get; set;}
        public int UserId {get; set;}
        public int IdeaId {get; set;}

        public DateTime CreatedAt{get; set;} = DateTime.Now;
        public DateTime UpdatedAt{get; set;} = DateTime.Now;

        public User Liker {get;set;}
        public BrightIdea IdeaLiked {get; set;}



    }
}