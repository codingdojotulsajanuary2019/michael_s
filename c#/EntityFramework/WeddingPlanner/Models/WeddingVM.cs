using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace WeddingPlanner.Models
{
    public class WeddingViewModel
    {
        public Wedding NewWedding {get;set;}
        public Wedding ThisWedding {get; set;}
        public Reservation NewRSVP {get; set;}
        public List<Wedding> AllWeddings {get; set;}
    }
}