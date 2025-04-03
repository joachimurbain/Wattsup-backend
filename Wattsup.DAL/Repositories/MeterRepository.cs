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

    protected override IQueryable<Meter> AddIncludes(IQueryable<Meter> query)
    {
        return query
				.Include(s => s.Store)
				.Include(s => s.Readings); 
    }
}
