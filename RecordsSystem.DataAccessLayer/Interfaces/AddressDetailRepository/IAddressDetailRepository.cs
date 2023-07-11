using RecordsSystem.DataAccessLayer.Entities;

namespace RecordsSystem.DataAccessLayer.Interfaces
{
    public interface IAddressDetailRepository
    {
        Task<IEnumerable<AddressDetail>> GetAddressDetailsAsync();
        //Task<AddressDetail> GetAddressDetailByIdAsync(int id);
        //Task<AddressDetail> AddAddressDetailAsync(AddressDetail addressDetail);
        //Task UpdateAddressDetailAsync(AddressDetail addressDetail);
        //Task DeleteAddressDetailAsync(int id);
    }
}
