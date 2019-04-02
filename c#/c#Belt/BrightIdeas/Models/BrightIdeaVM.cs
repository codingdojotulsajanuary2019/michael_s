using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace BrightIdeas.Models
{
    public class BrightIdeaVM
    {
        public User ThisUser {get; set;}
        public BrightIdea NewIdea {get; set;}
        public BrightIdea GetIdea {get; set;}
        public Like LikeThis {get; set;}
        public List<BrightIdea> AllIdeas {get; set;}
    }
}