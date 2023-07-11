using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecordsSystem.DataAccessLayer.Entities
{
    public class AddressDetail
    {
        [MaxLength(100)]
        public string? Country { get; set; }

        [ForeignKey(nameof(Country))]

        public RecUserDetail? RecUserDetail { get; set; }

        public int RecUserDetailId { get; set; }

        [MaxLength(100)]
        public string? Province { get; set; }

        [MaxLength(100)]
        public string? City { get; set; }

        [MaxLength(100)]
        public string? Suburb { get; set; }

        [MaxLength(100)]
        public string? PostalCode { get; set; }
        public int UnitNumber { get; set; }

        [MaxLength(100)]
        public string? ComplexName { get; set; }
    }
}
