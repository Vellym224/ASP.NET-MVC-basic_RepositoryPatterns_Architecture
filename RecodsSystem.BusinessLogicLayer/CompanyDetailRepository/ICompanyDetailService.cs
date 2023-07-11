using RecordsSystem.DataAccessLayer.Entities;

namespace RecodsSystem.BusinessLogicLayer.CompanyDetailRepository
{
    public interface ICompanyDetailService
    {
        Task<IEnumerable<CompanyDetail>> GetCompanyDetailsAsync();
        //Task<CompanyDetail> GetCompanyDetailByIdAsync(int id);
        //Task<CompanyDetail> AddCompanyDetailAsync(CompanyDetail companyDetail);
        //Task UpdateCompanyDetailAsync(CompanyDetail companyDetail);
        //Task DeleteCompanyDetailAsync(int id);
    }
}
