using NZWalksNew.Models.Domain;

namespace NZWalksNew.Repositories
{
    public interface IRegionRepository
    {
        Task<IEnumerable<Region>> GetAll();
    }
}
