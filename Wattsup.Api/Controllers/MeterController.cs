using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wattsup.Api.Controllers.Base;
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


}
