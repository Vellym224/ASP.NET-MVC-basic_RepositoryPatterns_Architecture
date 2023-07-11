namespace RecordsSystem.DataAccessLayer.Entities
{
    public class EmployeeDetail
    {
        public string Department { get; set; }
        public RecUserDetail RecUserDetail { get; set; }
        public int RecUserDetailId { get; set; }

        public string EmpRole { get; set; }
        public int Salary { get; set; }
    }
}
