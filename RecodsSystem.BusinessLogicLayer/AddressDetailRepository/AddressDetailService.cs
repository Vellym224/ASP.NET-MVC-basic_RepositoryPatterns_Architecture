using RecordsSystem.DataAccessLayer.Entities;
using RecordsSystem.DataAccessLayer.Interfaces;

namespace RecodsSystem.BusinessLogicLayer.AddressDetailRepository
{
    public class AddressDetailService : IAddressDetailService
    {
        public readonly IAddressDetailRepository _addressDetailRepository;
        public AddressDetailService(IAddressDetailRepository addressDetailRepository)
        {
            _addressDetailRepository = addressDetailRepository;
        }

        public async Task<IEnumerable<AddressDetail>> GetAddressDetailsAsync()
        {
            return await _addressDetailRepository.GetAddressDetailsAsync();
        }
    }
}
