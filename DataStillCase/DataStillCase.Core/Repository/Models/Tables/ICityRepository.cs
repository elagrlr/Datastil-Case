using DataStillCase.Entity.Models.Tables;

namespace DataStillCase.Core.Repository.Models.Tables
{
    public interface ICityRepository : IRepository<City>
    {
        Task<City> GetWithDetailAsync(int cityId);
    }
}
