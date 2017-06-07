using System;

namespace Ledger.Core
{
    public class Transaction:BaseEntity
    {
        public Transaction()
        {
            _id = Guid.NewGuid();
        }

        private Guid _id;
        public Guid Id { get { return _id; }}
        public DateTime TransactionDate { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; } 
        public int PaymentTypeId { get; set; }
		public bool IsDeposit { get; set; }


    }
}
