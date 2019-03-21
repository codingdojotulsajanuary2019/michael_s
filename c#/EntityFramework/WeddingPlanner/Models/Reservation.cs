using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace WeddingPlanner.Models
{
    public class Reservation
    {
        [Key]
        public int ReservationId {get; set;}

        public int UserId {get; set;}

        public int WeddingId {get; set;}
        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public DateTime UpdatedAt {get; set;} = DateTime.Now;

        public User Guest {get; set;}
        public Wedding Wedding {get; set;}
    }
}