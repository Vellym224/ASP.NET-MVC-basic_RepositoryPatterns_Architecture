using RecordsSystem.DataAccessLayer.Entities;

namespace RecodsSystem.BusinessLogicLayer.AddressDetailRepository
{
    public interface IAddressDetailService
    {
        Task<IEnumerable<AddressDetail>> GetAddressDetailsAsync();
        //Task<AddressDetail> GetAddressDetailByIdAsync(int id);
        //Task<AddressDetail> AddAddressDetailAsync(AddressDetail addressDetail);
        //Task UpdateAddressDetailAsync(AddressDetail addressDetail);
        //Task DeleteAddressDetailAsync(int id);
    }
}
