using CrudCore.Controllers;
using Microsoft.AspNetCore.Mvc;
using Wattsup.Api.DTOs.MeterDTOs;
using Wattsup.Api.DTOs.StoreDTOs;
using Wattsup.Api.Mappers;
using Wattsup.BLL.Services.Interfaces;
using Wattsup.Domain.Models;

namespace Wattsup.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class StoreController : BaseDtoController<Store, CreateStoreDto, UpdateStoreDto, DetailsStoreDto, ListStoreDto>
{


	public StoreController(IStoreService storeService) : base(storeService) { }

	[HttpGet("{storeId}/meters")]
	public async Task<ActionResult<IEnumerable<DetailsMeterDTO>>> GetMetersForStore(int storeId)
	{
		Store store = await _service.GetByIdAsync(storeId, CrudCore.Enums.TrackingBehavior.WithCollections);



		IEnumerable<DetailsMeterDTO> meters = store.Meters.Select(m => m.ToDetailsDto()).ToList();







		return Ok(meters);
	}

	protected override DetailsStoreDto ToDetailsDto(Store entity)
	{
		return entity.ToDetailsDto();
	}
	protected override Store ToEntity(CreateStoreDto createDto)
	{
		return createDto.ToEntity();
	}

	protected override ListStoreDto ToListDto(Store entity)
	{
		return entity.ToListDto();
	}

}
