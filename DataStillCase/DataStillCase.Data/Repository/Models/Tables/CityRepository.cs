using DataStillCase.Core.Repository.Models.Tables;
using DataStillCase.Entity.Models.Tables;
using Microsoft.EntityFrameworkCore;

namespace DataStillCase.Data.Repository.Models.Tables
{
    public class CityRepository : Repository<City>, ICityRepository
    {
        public CityRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<City> GetWithDetailAsync(int cityId)
        {
            return await _context.Cities
                .Include(c => c.Informations).Where(c => c.Id==cityId)
                .Include(c => c.VisitorHistories).Where(c => c.Id==cityId)                
                .FirstOrDefaultAsync()
            ?? Activator.CreateInstance<City>();
        }
    }
}
