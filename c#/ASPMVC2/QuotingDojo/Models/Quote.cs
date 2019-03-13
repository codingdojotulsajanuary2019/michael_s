using System;
using System.ComponentModel.DataAnnotations;

namespace QuotingDojo.Models
{
    public class Quotes
    {
        [Required (ErrorMessage="Name cannot be empty")]
        [MinLength(2, ErrorMessage="Name must be longer than 2 characters")]
        public string Name {get; set;}

        [Required (ErrorMessage="Quote field cannot be empty")]
        public string Quote {get; set;}
    }
}