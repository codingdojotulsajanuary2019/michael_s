using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace TheWall.Models
{
    public class Message
    {
        [Key]
        public int MessageId {get; set;}
        
        [Required(ErrorMessage="Post Cannot Be Blank")]
        [Display(Name="TEST")]
        public string UserMessage {get; set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        public int UserId {get; set;}
        public User MessageCreator {get; set;}

        public List<Comment> MessageComments {get; set;}
    }
}