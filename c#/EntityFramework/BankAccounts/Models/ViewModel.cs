using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace BankAccounts.Models
{
    public class ViewModel
    {
        public User ThisUser;
        public Transaction transaction;

        public decimal BalanceSum;
    }
}