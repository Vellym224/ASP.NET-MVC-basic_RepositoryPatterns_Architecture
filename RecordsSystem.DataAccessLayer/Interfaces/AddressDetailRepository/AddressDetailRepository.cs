using Microsoft.EntityFrameworkCore;
using RecordsSystem.DataAccessLayer.Data;
using RecordsSystem.DataAccessLayer.Entities;

namespace RecordsSystem.DataAccessLayer.Interfaces.AddressDetailRepository
{
    public class AddressDetailRepository : IAddressDetailRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public AddressDetailRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public async Task<IEnumerable<AddressDetail>> GetAddressDetailsAsync()
        {
            return await _applicationDbContext.AddressesDetails.ToListAsync();
        }

        // Other methods for CRUD
    }
}
