using Microsoft.EntityFrameworkCore;
using RecordsSystem.DataAccessLayer.Data;
using RecordsSystem.DataAccessLayer.Entities;

namespace RecordsSystem.DataAccessLayer.Interfaces.EmployeeDetailRepository
{
    public class EmployeeDetailRepository : IEmployeeDetailRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public EmployeeDetailRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<EmployeeDetail>> GetEmployeeDetailsAsync()
        {
            return await _dbContext.EmployeeDetails.ToListAsync();
        }

        // Other methods for CRUDS
    }
}
