using RecordsSystem.DataAccessLayer.Entities;
using RecordsSystem.DataAccessLayer.Interfaces.RecUserDetailRepository;

namespace RecodsSystem.BusinessLogicLayer.RecUserDetailRepository
{
    public class RecUserDetailService : IRecUserDetailService
    {
        private readonly IRecUseDetailRepository _recUseDetailRepository;

        public RecUserDetailService(IRecUseDetailRepository recUseDetailRepository)
        {
            _recUseDetailRepository = recUseDetailRepository;
        }
        public async Task<IEnumerable<RecUserDetail>> GetRecUserDetailsAsync()
        {
            return await _recUseDetailRepository.GetRecUserDetailsAsync();
        }



    }
}
