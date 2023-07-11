using Microsoft.EntityFrameworkCore;
using RecordsSystem.DataAccessLayer.Data;
using RecordsSystem.DataAccessLayer.Entities;

namespace RecordsSystem.DataAccessLayer.Interfaces.RecUserDetailRepository
{

    public class RecUserDetailRepository : IRecUseDetailRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public RecUserDetailRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<RecUserDetail>> GetRecUserDetailsAsync()
        {
            return await _dbContext.RecUserDetails.ToListAsync();
        }

        // Other methods for CRUD
    }
}
