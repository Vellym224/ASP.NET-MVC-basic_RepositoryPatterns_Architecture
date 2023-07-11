using Microsoft.EntityFrameworkCore;
using RecordsSystem.DataAccessLayer.Data;
using RecordsSystem.DataAccessLayer.Entities;

namespace RecordsSystem.DataAccessLayer.Interfaces.CompanyDetailRepository
{
    public class CompanyDetailRepository : ICompanyDetailRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public CompanyDetailRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<CompanyDetail>> GetCompanyDetailsAsync()
        {
            return await _dbContext.CompanyDetails.ToListAsync();
        }

        // Other methods for CRUD
    }
}
