using RecordsSystem.DataAccessLayer.Entities;

namespace RecordsSystem.DataAccessLayer.Interfaces.RecUserDetailRepository
{
    public interface IRecUseDetailRepository
    {
        Task<IEnumerable<RecUserDetail>> GetRecUserDetailsAsync();
        //Task<RecUserDetail> GetRecUserDetailByIdAsync(int id);
        //Task<RecUserDetail> AddRecUserDetailAsync(RecUserDetail recUserDetail);
        //Task UpdateRecUserDetailAsync(RecUserDetail recUserDetail);
        //Task DeleteRecUserDetailAsync(int id);
    }
}
