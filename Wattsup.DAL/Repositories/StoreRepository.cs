using CrudCore.Repositories;
using Microsoft.EntityFrameworkCore;
using Wattsup.DAL.Database;
using Wattsup.DAL.Repositories.Interfaces;
using Wattsup.Domain.Models;

namespace Wattsup.DAL.Repositories;
public class StoreRepository : BaseRepository<Store>, IStoreRepository
{
	private WattsupDbContext _wattsupDbContext => (WattsupDbContext)_dbContext;

	public StoreRepository(WattsupDbContext dbContext) : base(dbContext) { }


	protected override IQueryable<Store> AddIncludes(IQueryable<Store> query)
	{
		return query
			.Include(s => s.Manager)
			.Include(s => s.Meters).ThenInclude(r => r.Readings);
	}
}
