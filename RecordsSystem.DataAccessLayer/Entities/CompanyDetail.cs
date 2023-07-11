namespace RecordsSystem.DataAccessLayer.Entities
{
    public class CompanyDetail
    {
        public string? EmailAddress { get; set; }

        public RecUserDetail? RecUserDetail { get; set; }
        public int RecUserDetailId { get; set; }
        public long ContactNumber { get; set; }
        public int RegistrationNumber { get; set; }
        public string? Address { get; set; }
        public string? BusinessType { get; set; }
    }
}
