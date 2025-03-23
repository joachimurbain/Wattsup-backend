using Microsoft.AspNetCore.Mvc;
using Wattsup.Api.Controllers.Base;
using Wattsup.BLL.Services.Interfaces;
using Wattsup.Domain.Models;

namespace Wattsup.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class StoreController : CrudEntityController<Store>
{
	private readonly IStoreService _storeService;

	public StoreController(IStoreService storeService) : base(storeService)
	{
		_storeService = storeService;
	}


}
