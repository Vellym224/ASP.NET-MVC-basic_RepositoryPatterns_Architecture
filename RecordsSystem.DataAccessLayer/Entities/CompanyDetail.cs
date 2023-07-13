using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecordsSystem.DataAccessLayer.Entities
{
    public class CompanyDetail
    {
        [Key]
        [MaxLength(100)]
        [ForeignKey(nameof(EmailAddress))]
        public string? EmailAddress { get; set; }

        public RecUserDetail? RecUserDetail { get; set; }


        public int RecUserDetailId { get; set; }

        [MaxLength(100)]
        public long ContactNumber { get; set; }
        public int RegistrationNumber { get; set; }

        [MaxLength(100)]
        public string? Address { get; set; }

        [MaxLength(150)]

        public string? BusinessType { get; set; }
    }
}
