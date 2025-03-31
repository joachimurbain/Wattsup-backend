using Microsoft.AspNetCore.Mvc;
using Wattsup.Api.Controllers.Base;
using Wattsup.Api.DTOs.StoreDTOs;
using Wattsup.Api.Mappers;
using Wattsup.BLL.Services.Interfaces;
using Wattsup.Domain.Models;

namespace Wattsup.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class MeterController : BaseEntityController<Meter>
{
	private readonly IMeterService _meterService;

	public MeterController(IMeterService meterService) : base(meterService)
	{
		_meterService = meterService;
	}

	[HttpGet("{meterId}/readings")]
	public async Task<ActionResult<IEnumerable<DetailsMeterReadingDto>>> GetReadingsForMeter(int meterId)
	{
		Meter meter = await _service.GetByIdAsync(meterId);
		IEnumerable<DetailsMeterReadingDto> meterReadings = meter.Readings.Select(m => m.ToDetailsDto());
		return Ok(meterReadings);
	}

}
