using Wattsup.Api.DTOs.MeterReadingDTOs;
using Wattsup.Api.DTOs.StoreDTOs;
using Wattsup.Domain.Models;

namespace Wattsup.Api.Mappers;

public static class MeterReadingMappers
{
	public static DetailsMeterReadingDto ToDetailsDto(this MeterReading entity)
	{
		return new DetailsMeterReadingDto
		{
			Id = entity.Id,
			ReadingDate = entity.ReadingDate,
			Value = entity.Value,
			Source = entity.Source,
			MeterId = entity.MeterId,
		};
	}

	public static MeterReading ToEntity(this CreateMeterReadingDTO createDto)
	{
		return new MeterReading
		{
			Value = createDto.Value,
			Source = createDto.Source,
			ReadingDate = createDto.ReadingDate,
			Meter = null
		};
	}

	public static ListMeterReadingDTO ToListMeterReadingDto(this MeterReading entity)
	{
		return new ListMeterReadingDTO
		{
			Id = entity.Id,
			Value = entity.Value,
			ReadingDate = entity.ReadingDate,
			MeterId = entity.Id
		};
	}
}
