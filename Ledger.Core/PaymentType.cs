using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Ledger.Core
{
    [Table("PaymentType")]
    [DataContract]
    public class PaymentType : BaseEntity
    {
        [Key]
        [DataMember]
        public int Id { get; set; }

        [Required]
        [DataMember]
        public string Name { get; set; }
    }
}