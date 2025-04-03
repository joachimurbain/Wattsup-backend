using CrudCore.Repositories;
using Wattsup.DAL.Database;

using Wattsup.DAL.Repositories.Interfaces;
using Wattsup.Domain.Models;

namespace Wattsup.DAL.Repositories;
public class MeterReadingRepository : BaseRepository<MeterReading>, IMeterReadingRepository
{
	public MeterReadingRepository(WattsupDbContext dbContext) : base(dbContext) { }

}