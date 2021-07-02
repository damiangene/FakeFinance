using System.Collections.Generic;

namespace FakeFinance.Models
{
    public class Customer
    {
        public string Id { get; set; } = default!;
        public string Name { get; set; } = default!;

        public List<BankAccount> BankAccounts { get; set; } = new List<BankAccount>();
    }
}
