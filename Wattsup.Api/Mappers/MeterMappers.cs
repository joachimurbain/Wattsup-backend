using Wattsup.Api.DTOs.MeterDTOs;
using Wattsup.Domain.Models;

namespace Wattsup.Api.Mappers;

public static class MeterMappers
{
	public static DetailsMeterDTO ToDetailsDto(this Meter entity)
	{
		return new DetailsMeterDTO
		{
			Id = entity.Id,
			DeactivationDate = entity.DeactivationDate,
			QrCode = entity.QrCode,
			StoreId = entity.Store.Id,
			Type = entity.Type,
			Uuid = entity.Uuid,
			LastReading = entity.Readings
				.OrderByDescending(r => r.ReadingDate)
				.Select(r => r.ReadingDate)
				.FirstOrDefault()


		};
	}
}
