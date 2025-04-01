using CrudCore.Repositories;
using Microsoft.EntityFrameworkCore;
using Wattsup.DAL.Database;
using Wattsup.DAL.Repositories.Interfaces;
using Wattsup.Domain.Models;

namespace Wattsup.DAL.Repositories;
public class MeterRepository : BaseRepository<Meter>, IMeterRepository
{

	private WattsupDbContext _wattsupDbContext => (WattsupDbContext)_dbContext;

	public MeterRepository(WattsupDbContext dbContext) : base(dbContext) { }

	protected override IQueryable<Meter> AddReferences(IQueryable<Meter> query)
	{
		return query.Include(s => s.Store);
	}

	protected override IQueryable<Meter> AddCollections(IQueryable<Meter> query)
	{
		return query.Include(s => s.Readings);
	}
}
