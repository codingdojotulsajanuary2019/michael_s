using System;
using System.ComponentModel.DataAnnotations;

namespace DojoSurveyWithModels.Models
{
    public class Survey
    {
        [Required (ErrorMessage="Must Not Be Empty")]
        [MinLength(2, ErrorMessage="Name emust be longer than 2")]
        public string Name {get; set;}

        [Required]
        public string Location {get; set;}

        [Required]
        public string Language {get; set;}

        [MinLength(20)]
        public string Comments {get; set;}
       
    }
}