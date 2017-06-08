using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ledger.Core
{
    [Table("Transaction")]
    public class Transaction : BaseEntity
    {
        //public Transaction()
        //{
        //    this.Id = Guid.NewGuid();
        //}

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required]
        public Guid AccountId { get; set; }

        [Required]
        public DateTime TransactionDate { get; set; }

        public string Description { get; set; }
        public int CategoryId { get; set; }
        public int PaymentTypeId { get; set; }

        [Required]
        public bool IsDeposit { get; set; }

        [Required]
        public decimal Amount { get; set; }
    }
}