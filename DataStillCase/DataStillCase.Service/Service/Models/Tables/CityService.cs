using DataStillCase.Core.Repository;
using DataStillCase.Core.Service.Models.Tables;
using DataStillCase.Core.UnitOfWork;
using DataStillCase.Entity.Models.Tables;

namespace DataStillCase.Service.Service.Models.Tables
{
    public class CityService : Service<City>, ICityService
    {
        public CityService(IUnitOfWork unitOfWork, IRepository<City> repository) : base(unitOfWork, repository)
        {
        }

        public async Task<City> GetWithDetailAsync(int cityId)
        {
            return await _unitOfWork.CityRepository.GetWithDetailAsync(cityId);
        }
    }
}
