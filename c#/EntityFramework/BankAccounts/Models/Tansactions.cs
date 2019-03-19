using System;
using System.ComponentModel.DataAnnotations;

namespace BankAccounts.Models
{
    public class Transaction
    {
        [Key]
        public long TransactionId {get; set;}

        [Required(ErrorMessage =" You must provide amount")]
        [DataType(DataType.Currency)]
        public decimal Amount {get; set;}

        public DateTime CreatedAt {get; set;} = DateTime.Now;

        public DateTime UpdatedAt {get; set;} = DateTime.Now;

        public int UserId {get; set;}

        public User Sender {get; set;}

    }
}