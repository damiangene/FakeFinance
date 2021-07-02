namespace FakeFinance.Models
{
    public class Transaction : AuditEntity
    {
        public decimal Amount { get; set; }
        public string DebitAccountId { get; set; } = default!;
        public string CreditAccountId { get; set; } = default!;
    }
}
