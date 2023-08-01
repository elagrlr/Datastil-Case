using DataStillCase.Core.Repository.Models.Tables;
using DataStillCase.Entity.Models.Tables;

namespace DataStillCase.Data.Repository.Models.Tables
{
    public class InformationRepository : Repository<Information>, IInformationRepository
    {
        public InformationRepository(AppDbContext context) : base(context)
        {
        }
    }
}
