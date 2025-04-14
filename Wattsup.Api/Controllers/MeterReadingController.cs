using CrudCore.Controllers;
using CrudCore.Mapping;
using Microsoft.AspNetCore.Mvc;
using Wattsup.Api.DTOs.MeterReadingDTOs;
using Wattsup.Api.DTOs.StoreDTOs;
using Wattsup.BLL.Services.Interfaces;
using Wattsup.DAL.Database;
using Wattsup.Domain.Models;

namespace Wattsup.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class MeterReadingController : BaseDtoController<MeterReading, CreateMeterReadingDTO, UpdateMeterReadingDTO, DetailsMeterReadingDto, ListMeterReadingDTO>
{

	private readonly IMeterService _meterService;

	public MeterReadingController(IMeterReadingService meterReadingService, IMeterService meterService, IMapper mapper, WattsupDbContext dbContext) : base(meterReadingService, mapper)
	{
		_meterService = meterService;
	}

	protected override MeterReading ToEntity(CreateMeterReadingDTO createDto)
	{
		MeterReading meterReading = _mapper.Map<CreateMeterReadingDTO, MeterReading>(createDto);
		meterReading.Meter = _meterService.GetByIdAsync(createDto.MeterId).GetAwaiter().GetResult();
		return meterReading;
	}
}