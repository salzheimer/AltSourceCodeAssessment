using System;
using System.Runtime.Serialization;

namespace Ledger.Core
{
    [DataContract]
    public class BaseEntity
    {
        [DataMember]
        public DateTime DateCreated { get; set; }
        [DataMember]
        public DateTime? DateUpdated { get; set; }
        [DataMember]
        public string CreatedBy { get; set; }
        [DataMember]
        public string UpdatedBy { get; set; }
    }
}