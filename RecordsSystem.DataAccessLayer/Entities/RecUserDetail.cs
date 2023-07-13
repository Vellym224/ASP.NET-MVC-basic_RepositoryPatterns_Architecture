using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecordsSystem.DataAccessLayer.Entities
{
    public class RecUserDetail
    {

        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(Name))]
        public string? Name { get; set; }
        [MaxLength(100)]
        public string? Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public long IdentityNumber { get; set; }

        [MaxLength(250)]
        public string? Address { get; set; }

        [MaxLength(100)]
        public string? EmailAddress { get; set; }
        public long ContactNumber { get; set; }
    }
}
