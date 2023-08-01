using DataStillCase.Core.Repository.Models.Tables;
using DataStillCase.Core.UnitOfWork;
using DataStillCase.Data.Repository.Models.Tables;

namespace DataStillCase.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private CityRepository _cityRepository;
        private InformationRepository _informationRepository;
        private VisitorHistoryRepository _visitorHistoryRepository;

        private readonly AppDbContext _context;
        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public ICityRepository CityRepository => _cityRepository ?? new CityRepository(_context);

        public IInformationRepository InformationRepository => _informationRepository ?? new InformationRepository(_context);

        public IVisitorHistoryRepository VisitorHistoryRepository => _visitorHistoryRepository ?? new VisitorHistoryRepository(_context);

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
