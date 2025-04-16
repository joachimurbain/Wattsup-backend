using CrudCore.Controllers;
using CrudCore.Mapping;
using Microsoft.AspNetCore.Mvc;
using Wattsup.Api.DTOs.MeterDTOs;
using Wattsup.Api.DTOs.StoreDTOs;
using Wattsup.BLL.Services.Interfaces;
using Wattsup.Domain.Models;

namespace Wattsup.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class MeterController : BaseDtoController<Meter, CreateMeterDTO, DetailsMeterDTO, DetailsMeterDTO, DetailsMeterDTO>
{
	private readonly IMeterService _meterService;

	public MeterController(IMeterService meterService, IMapper mapper) : base(meterService, mapper)
	{
		_meterService = meterService;
	}

	[HttpGet("{meterId}/readings")]
	public async Task<ActionResult<IEnumerable<DetailsMeterReadingDto>>> GetReadingsForMeter(int meterId)
	{
		Meter meter = await _service.GetByIdAsync(meterId);
		IEnumerable<DetailsMeterReadingDto> meterReadings = meter.Readings.Select(m => _mapper.Map<MeterReading, DetailsMeterReadingDto>(m));

		return Ok(meterReadings);
	}

	protected override DetailsMeterDTO ToDetailsDto(Meter entity)
	{
		var dto = _mapper.Map<Meter, DetailsMeterDTO>(entity);

		dto.StoreId = entity.Store.Id;
		dto.LastReading = entity.Readings
			.OrderByDescending(r => r.ReadingDate)
			.Select(r => r.ReadingDate)
			.FirstOrDefault();

		return dto;
	}

	protected override DetailsMeterDTO ToListDto(Meter entity)
	{
		return ToDetailsDto(entity);
	}
}
