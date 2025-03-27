using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wattsup.DAL.Database;
using Wattsup.DAL.Repositories.Base;
using Wattsup.DAL.Repositories.Interfaces;
using Wattsup.Domain.Models;

namespace Wattsup.DAL.Repositories;
public class MeterRepository : BaseRepository<Meter>, IMeterRepository
{

    public MeterRepository(WattsupDbContext dbContext) : base(dbContext) { }

    public override async Task<Meter?> GetByIdAsync(int id)
    {
        return await _dbContext.Meters
            .Include(s => s.Store)
            .AsNoTracking()
            .FirstOrDefaultAsync(s => s.Id == id);
    }
}
