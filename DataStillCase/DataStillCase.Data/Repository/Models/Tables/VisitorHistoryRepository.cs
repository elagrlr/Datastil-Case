using DataStillCase.Core.Repository.Models.Tables;
using DataStillCase.Entity.Models.Tables;

namespace DataStillCase.Data.Repository.Models.Tables
{
    public class VisitorHistoryRepository : Repository<VisitorHistory>, IVisitorHistoryRepository
    {
        public VisitorHistoryRepository(AppDbContext context) : base(context)
        {
        }
    }
}
