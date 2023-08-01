using DataStillCase.Core.Repository;
using DataStillCase.Core.Service.Models.Tables;
using DataStillCase.Core.UnitOfWork;
using DataStillCase.Entity.Models.Tables;

namespace DataStillCase.Service.Service.Models.Tables
{
    public class VisitorHistoryService : Service<VisitorHistory>, IVisitorHistoryService
    {
        public VisitorHistoryService(IUnitOfWork unitOfWork, IRepository<VisitorHistory> repository) : base(unitOfWork, repository)
        {
        }
    }
}
