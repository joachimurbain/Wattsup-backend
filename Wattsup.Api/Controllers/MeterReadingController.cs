using CrudCore.Controllers;
using CrudCore.Controllers.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Wattsup.Api.DTOs.MeterReadingDTOs;
using Wattsup.Api.DTOs.StoreDTOs;
using Wattsup.Api.Mappers;
using Wattsup.BLL.Services.Interfaces;
using Wattsup.DAL.Database;
using Wattsup.Domain.Models;

namespace Wattsup.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class MeterReadingController : BaseDtoController<MeterReading, CreateMeterReadingDTO, UpdateMeterReadingDTO, DetailsMeterReadingDto, ListMeterReadingDTO>
{
	private readonly IMeterReadingService _meterReadingService;

	private readonly IMeterService _meterService;

	private readonly WattsupDbContext _dbContext;

	public MeterReadingController(IMeterReadingService meterReadingService, IMeterService meterService, WattsupDbContext dbContext) : base(meterReadingService)
	{
		_meterReadingService = meterReadingService;
		_meterService = meterService;
		_dbContext = dbContext;
	}

    [HttpPut("{id}")]
    public override async Task<ActionResult<DetailsMeterReadingDto>> Update(int id, [FromBody] UpdateMeterReadingDTO dto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var patch = PatchEntityBuilder.BuildPartial<MeterReading, UpdateMeterReadingDTO>(dto);


		Meter meter = await _meterService.GetByIdAsync(dto.MeterId);

        var existingReading = _dbContext.ChangeTracker.Entries<MeterReading>()
    .FirstOrDefault(e => e.Entity.Id == dto.Id);
        if (existingReading != null)
        {
            existingReading.State = EntityState.Detached;
        }

        patch.PartialEntity.Meter = meter;
        patch.UpdatedFields.Add("Meter");


        var updated = await _service.UpdateAsync(id, patch);
        return Ok(ToDetailsDto(updated));
    }

    protected override DetailsMeterReadingDto ToDetailsDto(MeterReading entity)
	{
		return entity.ToDetailsDto();
	}

	protected override MeterReading ToEntity(CreateMeterReadingDTO createDto)
	{
		MeterReading meterReading = createDto.ToEntity();
		meterReading.Meter = _meterService.GetByIdAsync(createDto.MeterId).GetAwaiter().GetResult();
		return meterReading;

	}

	protected override ListMeterReadingDTO ToListDto(MeterReading entity)
	{
		return entity.ToListMeterReadingDto();
	}
}