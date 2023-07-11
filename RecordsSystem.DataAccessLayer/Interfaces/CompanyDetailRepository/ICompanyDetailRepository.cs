using RecordsSystem.DataAccessLayer.Entities;

namespace RecordsSystem.DataAccessLayer.Interfaces.CompanyDetailRepository
{
    public interface ICompanyDetailRepository
    {
        Task<IEnumerable<CompanyDetail>> GetCompanyDetailsAsync();
        //Task<CompanyDetail> GetCompanyDetailByIdAsync(int id);
        //Task<CompanyDetail> AddCompanyDetailAsync(CompanyDetail companyDetail);
        //Task UpdateCompanyDetailAsync(CompanyDetail companyDetail);
        //Task DeleteCompanyDetailAsync(int id);
    }
}
