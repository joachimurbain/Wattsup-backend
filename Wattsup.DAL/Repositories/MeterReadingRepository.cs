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
public class MeterReadingRepository : BaseRepository<MeterReading>, IMeterReadingRepository
{
    public MeterReadingRepository(WattsupDbContext dbContext) : base(dbContext) { }
}