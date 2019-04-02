using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace TheWall.Models
{
    public class Comment
    {
        [Key]
        public int CommentId {get; set;}
        public int UserId {get; set;}
        public int MessageId {get; set;}
        public string UserComment {get; set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        public User CommentCreator {get; set;}

    }
}