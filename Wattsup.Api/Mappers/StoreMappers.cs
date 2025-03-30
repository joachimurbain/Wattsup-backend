using Wattsup.Api.DTOs.StoreDTOs;
using Wattsup.Domain.Models;

namespace Wattsup.Api.Mappers;

public static class StoreMappers
{
	public static DetailsStoreDto ToDetailsDto(this Store entity)
	{
		return new DetailsStoreDto
		{
			Id = entity.Id,
			Name = entity.Name,
			Address = entity.Address,
			City = entity.City,
			StoreCode = entity.StoreCode,
			Zipcode = entity.Zipcode,
			IsActive = entity.IsActive,
			SurfaceArea = entity.SurfaceArea,
			Manager = entity.Manager,
			Meters = entity.Meters.Select(m => m.ToDetailsDto()).ToList()
		};
	}

	public static Store ToEntity(this CreateStoreDto createDto)
	{
		return new Store
		{
			Name = createDto.Name,
			Address = createDto.Address,
			City = createDto.City,
			StoreCode = createDto.StoreCode,
			Zipcode = createDto.Zipcode,
		};
	}

	public static ListStoreDto ToListDto(this Store entity)
	{
		return new ListStoreDto
		{
			Id = entity.Id,
			Name = entity.Name,
			City = entity.City,
			StoreCode = entity.StoreCode,
			IsActive = entity.IsActive,
		};
	}
}
