using DataStillCase.Core.Repository.Models.Tables;

namespace DataStillCase.Core.UnitOfWork
{
    public interface IUnitOfWork
    {
        ICityRepository CityRepository { get; }
        IInformationRepository InformationRepository { get; }
        IVisitorHistoryRepository VisitorHistoryRepository { get; }


        Task CommitAsync();
        void Commit();
    }
}
