using System;
using System.Collections.Generic;

namespace FakeFinance.Models
{
    public class BankAccount
    {
        public Guid BankAccountId { get; set; }
        public Guid CustomerId { get; set; }
        public decimal Balance { get; set; }

        public List<Transaction> TransactionHistory { get; set; } = new List<Transaction>();
    }
}
