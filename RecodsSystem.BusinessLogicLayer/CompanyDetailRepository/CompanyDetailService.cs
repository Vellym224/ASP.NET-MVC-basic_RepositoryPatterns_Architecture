using RecordsSystem.DataAccessLayer.Entities;
using RecordsSystem.DataAccessLayer.Interfaces.CompanyDetailRepository;

namespace RecodsSystem.BusinessLogicLayer.CompanyDetailRepository
{
    public class CompanyDetailService : ICompanyDetailService
    {
        private readonly ICompanyDetailRepository _companyDetailRepository;

        public CompanyDetailService(ICompanyDetailRepository companyDetailRepository)
        {
            _companyDetailRepository = companyDetailRepository;
        }
        public async Task<IEnumerable<CompanyDetail>> GetCompanyDetailsAsync()
        {
            return await _companyDetailRepository.GetCompanyDetailsAsync();
        }
    }
}
