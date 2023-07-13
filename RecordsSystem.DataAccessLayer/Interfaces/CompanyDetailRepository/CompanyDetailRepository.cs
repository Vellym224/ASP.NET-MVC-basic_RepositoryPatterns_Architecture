using Microsoft.EntityFrameworkCore;
using RecordsSystem.DataAccessLayer.Data;
using RecordsSystem.DataAccessLayer.Entities;

namespace RecordsSystem.DataAccessLayer.Interfaces.CompanyDetailRepository
{
    public class CompanyDetailRepository : ICompanyDetailRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public CompanyDetailRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public async Task<IEnumerable<CompanyDetail>> GetCompanyDetailsAsync()
        {
            return await _applicationDbContext.CompanyDetails.ToListAsync();
        }

        // Other methods for CRUD
    }
}
