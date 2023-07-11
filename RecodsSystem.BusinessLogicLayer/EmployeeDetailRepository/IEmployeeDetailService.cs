using RecordsSystem.DataAccessLayer.Entities;

namespace RecodsSystem.BusinessLogicLayer.EmployeeDetailRepository
{
    public interface IEmployeeDetailService
    {
        Task<IEnumerable<EmployeeDetail>> GetEmployeeDetailsAsync();
        //Task<EmployeeDetail> GetEmployeeDetailByIdAsync(int id);
        //Task<EmployeeDetail> AddEmployeeDetailAsync(EmployeeDetail employeeDetail);
        //Task UpdateEmployeeDetailAsync(EmployeeDetail employeeDetail);
        //Task DeleteEmployeeDetailAsync(int id);
    }
}
