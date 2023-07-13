using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecordsSystem.DataAccessLayer.Entities
{
    public class EmployeeDetail
    {

        [MaxLength(100)]
        [ForeignKey(nameof(Department))]
        public string? Department { get; set; }
        public RecUserDetail? RecUserDetail { get; set; }
        public int RecUserDetailId { get; set; }

        [MaxLength(100)]
        public string? EmpRole { get; set; }

        public int Salary { get; set; }
    }
}
