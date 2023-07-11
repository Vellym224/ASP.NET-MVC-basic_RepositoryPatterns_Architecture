using RecordsSystem.DataAccessLayer.Entities;

namespace RecordsSystem.DataAccessLayer.Interfaces.EmployeeDetailRepository
{
    public interface IEmployeeDetailRepository
    {
        Task<IEnumerable<EmployeeDetail>> GetEmployeeDetailsAsync();
        //Task<EmployeeDetail> GetEmployeeDetailByIdAsync(int id);
        //Task<EmployeeDetail> AddEmployeeDetailAsync(EmployeeDetail employeeDetail);
        //Task UpdateEmployeeDetailAsync(EmployeeDetail employeeDetail);
        //Task DeleteEmployeeDetailAsync(int id);
    }
}
