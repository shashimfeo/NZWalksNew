using Microsoft.EntityFrameworkCore;
using NZWalksNew.Data;
using NZWalksNew.Models.Domain;

namespace NZWalksNew.Repositories
{
    public class RegionRepository : IRegionRepository
    {
        private readonly NZWalksDBContext nZWalksDBContext;

        public RegionRepository(NZWalksDBContext nZWalksDBContext)
        {
            this.nZWalksDBContext = nZWalksDBContext;
        }


        public async Task<IEnumerable<Region>> GetAll()
        {
           return await nZWalksDBContext.regions.ToListAsync();
        }
    }
}
