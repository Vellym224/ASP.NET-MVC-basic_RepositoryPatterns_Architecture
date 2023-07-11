using Microsoft.EntityFrameworkCore;
using RecordsSystem.DataAccessLayer.Data;
using RecordsSystem.DataAccessLayer.Entities;

namespace RecordsSystem.DataAccessLayer.Interfaces.AddressDetailRepository
{
    public class AddressDetailRepository : IAddressDetailRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public AddressDetailRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<AddressDetail>> GetAddressDetailsAsync()
        {
            return await _dbContext.AddressesDetails.ToListAsync();
        }

        // Other methods for CRUD
    }
}
