using Microsoft.EntityFrameworkCore;
using RecordsSystem.DataAccessLayer.Data;
using RecordsSystem.DataAccessLayer.Entities;

namespace RecordsSystem.DataAccessLayer.Interfaces.RecUserDetailRepository
{

    public class RecUserDetailRepository : IRecUseDetailRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public RecUserDetailRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = _applicationDbContext;
        }
        public async Task<IEnumerable<RecUserDetail>> GetRecUserDetailsAsync()
        {
            return await _applicationDbContext.RecUserDetails.ToListAsync();
        }

        // Other methods for CRUD
    }
}
