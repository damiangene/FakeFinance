using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakeFinance.Models
{
    public class Transaction : AuditEntity
    {
        public decimal Amount { get; set; }
    }
}
