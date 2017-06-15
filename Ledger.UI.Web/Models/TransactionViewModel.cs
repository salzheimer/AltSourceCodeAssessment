using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ledger.UI.Web.Models
{
    public class TransactionViewModel
    {
        public Guid AccoutId { get; set; }
        public DateTime TransactionDate { get; set; }
        public string DisplayTransactionDate { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int PaymentTypeId { get; set; }
        public string PaymentTypeName { get; set; }
        public bool IsDeposit { get; set; }
        public decimal Amount { get; set; }
        public string CreatedBy { get; set; }
    }
}