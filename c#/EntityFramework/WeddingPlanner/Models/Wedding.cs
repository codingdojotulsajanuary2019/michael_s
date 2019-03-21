 using System;
 using System.ComponentModel.DataAnnotations;
 using System.ComponentModel.DataAnnotations.Schema;
 using System.Collections.Generic;

 
 namespace WeddingPlanner.Models
 {
     public class Wedding
     {
         [Key]
         public int WeddingId {get; set;}

         public string Wedder1 {get; set;}
         public string Wedder2 {get; set;}
         public DateTime Date {get; set;}

         public string Location {get; set;}

         public DateTime CreatedAt {get; set;} = DateTime.Now;
         public DateTime UpdatedAt {get; set;} = DateTime.Now;
         public int UserId {get; set;}

         public User Creator {get; set;}

         public List<Reservation> Guests {get; set;}
     }
 }