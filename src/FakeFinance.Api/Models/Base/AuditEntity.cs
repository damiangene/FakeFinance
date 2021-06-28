using System;

namespace FakeFinance.Models
{
    public class AuditEntity
    {
        public DateTimeOffset CreatedDateTime { get; set; }
        public string CreatedBy { get; set; } = default!;
    }
}
