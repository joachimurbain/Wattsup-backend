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
public class StoreController : BaseDtoController<Store, CreateStoreDto, UpdateStoreDto, DetailsStoreDto, ListStoreDto>
{


	public StoreController(IStoreService storeService, IMapper mapper) : base(storeService, mapper) { }

	[HttpGet("{storeId}/meters")]
	public async Task<ActionResult<IEnumerable<DetailsMeterDTO>>> GetMetersForStore(int storeId)
	{
		Store store = await _service.GetByIdAsync(storeId);
		IEnumerable<DetailsMeterDTO> meters = store.Meters
			.Select(m => _mapper.Map<Meter, DetailsMeterDTO>(m))
			.ToList();
		return Ok(meters);
	}
}
