using System;
using System.ComponentModel.DataAnnotations;

namespace T3.S3Ledger.Api.Data.Entities
{
    public abstract class BaseEntity
    {
        [Key]
        public long Id { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
