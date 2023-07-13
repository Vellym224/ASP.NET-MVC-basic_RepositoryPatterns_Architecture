using Microsoft.EntityFrameworkCore;
using RecordsSystem.DataAccessLayer.Data;
using RecordsSystem.DataAccessLayer.Entities;

namespace RecordsSystem.DataAccessLayer.Interfaces.EmployeeDetailRepository
{
    public class EmployeeDetailRepository : IEmployeeDetailRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public EmployeeDetailRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public async Task<IEnumerable<EmployeeDetail>> GetEmployeeDetailsAsync()
        {
            return await _applicationDbContext.EmployeeDetails.ToListAsync();
        }

        // Other methods for CRUDS
    }
}
