using RecordsSystem.DataAccessLayer.Entities;
using RecordsSystem.DataAccessLayer.Interfaces.EmployeeDetailRepository;

namespace RecodsSystem.BusinessLogicLayer.EmployeeDetailRepository
{
    public class EmployeeDetailService : IEmployeeDetailService
    {
        private readonly IEmployeeDetailRepository _employeeDetailRepository;

        public EmployeeDetailService(IEmployeeDetailRepository employeeDetailRepository)
        {
            _employeeDetailRepository = employeeDetailRepository;
        }

        public async Task<IEnumerable<EmployeeDetail>> GetEmployeeDetailsAsync()
        {
            return await _employeeDetailRepository.GetEmployeeDetailsAsync();
        }
    }
}
