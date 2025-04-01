﻿using CrudCore.Repositories;
using Microsoft.EntityFrameworkCore;
using Wattsup.DAL.Database;
using Wattsup.DAL.Repositories.Interfaces;
using Wattsup.Domain.Models;

namespace Wattsup.DAL.Repositories;
public class MeterRepository : BaseRepository<Meter>, IMeterRepository
{

    private WattsupDbContext _wattsupDbContext => (WattsupDbContext)_dbContext;

    public MeterRepository(WattsupDbContext dbContext) : base(dbContext) { }

	public override async Task<Meter?> GetByIdAsync(int id)
	{
		return await _wattsupDbContext.Meters
			.Include(s => s.Store)
			.Include(s => s.Readings)
			.AsNoTracking()
			.FirstOrDefaultAsync(s => s.Id == id);
	}
}
