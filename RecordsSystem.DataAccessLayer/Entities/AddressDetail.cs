namespace RecordsSystem.DataAccessLayer.Entities
{
    public class AddressDetail
    {
        public string Country { get; set; }
        public RecUserDetail RecUserDetail { get; set; }
        public int RecUserDetailId { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string Suburb { get; set; }
        public string PostalCode { get; set; }
        public int UnitNumber { get; set; }
        public string ComplexName { get; set; }
    }
}
