using RecordsSystem.DataAccessLayer.Entities;

namespace RecodsSystem.BusinessLogicLayer.RecUserDetailRepository
{
    public interface IRecUserDetailService
    {
        Task<IEnumerable<RecUserDetail>> GetRecUserDetailsAsync();
        //Task<RecUserDetail> GetRecUserDetailByIdAsync(int id);
        //Task<RecUserDetail> AddRecUserDetailAsync(RecUserDetail recUserDetail);
        //Task UpdateRecUserDetailAsync(RecUserDetail recUserDetail);
        //Task DeleteRecUserDetailAsync(int id);
    }
}
