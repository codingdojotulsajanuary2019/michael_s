using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace TheWall.Models
{
    public class WallViewModel
    {
        public User User {get;set;}
        public Message NewMessage {get; set;}
    }
}