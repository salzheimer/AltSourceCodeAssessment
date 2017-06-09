using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Ledger.Core
{
    [Table("Category")]
    [DataContract]
    public class Category : BaseEntity
    {
        [Key]
        [DataMember]
        public int Id { get; set; }

        [Required]
        [DataMember]
        public string CategoryName { get; set; }
    }
}