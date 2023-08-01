using DataStillCase.Core.Repository;
using DataStillCase.Core.Service.Models.Tables;
using DataStillCase.Core.UnitOfWork;
using DataStillCase.Entity.Models.Tables;

namespace DataStillCase.Service.Service.Models.Tables
{
    public class InformationService : Service<Information>, IInformationService
    {
        public InformationService(IUnitOfWork unitOfWork, IRepository<Information> repository) : base(unitOfWork, repository)
        {
        }
    }
}
