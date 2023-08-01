using DataStillCase.Entity.Models.Tables;

namespace DataStillCase.Core.Service.Models.Tables
{
    public interface ICityService : IService<City>
    {
        Task<City> GetWithDetailAsync(int cityId);
    }
}
