using System.ComponentModel.DataAnnotations;

namespace T3.S3Ledger.Api.Data.Entities
{
    public class Country
    {
        public int Id { get; set; }
        [MaxLength(2)]
        public string Code { get; set; }
        public string ISOCode3 { get; set; }
        public int? IDDCode { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
    }
}
