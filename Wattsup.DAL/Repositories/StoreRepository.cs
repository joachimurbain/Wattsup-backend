using Microsoft.EntityFrameworkCore;
using Wattsup.DAL.Database;
using Wattsup.DAL.Repositories.Base;
using Wattsup.DAL.Repositories.Interfaces;
using Wattsup.Domain.Models;

namespace Wattsup.DAL.Repositories;
public class StoreRepository : BaseRepository<Store>, IStoreRepository
{

	public StoreRepository(WattsupDbContext dbContext) : base(dbContext) { }

	public override async Task<Store?> GetByIdAsync(int id)
	{
		return await _dbContext.Stores
			.Include(s => s.Manager)
            .Include(s => s.Meters)
            .AsNoTracking()
			.FirstOrDefaultAsync(s => s.Id == id);
	}


}
