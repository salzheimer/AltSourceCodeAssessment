using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Ledger.Core
{
    [DataContract]
    [Table("Transaction")]
    public class Transaction : BaseEntity
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DataMember]
        public Guid Id { get; set; }

        [Required]
        [DataMember]
        public Guid AccountId { get; set; }

        [Required]
        [DataMember]
        public DateTime TransactionDate { get; set; }

        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public int CategoryId { get; set; }
        [DataMember]
        public int PaymentTypeId { get; set; }

        [Required]
        [DataMember]
        public bool IsDeposit { get; set; }

        [Required]
        [DataMember]
        public decimal Amount { get; set; }
    }
}