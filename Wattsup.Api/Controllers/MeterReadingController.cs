using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wattsup.Api.Controllers.Base;
using Wattsup.BLL.Services.Interfaces;
using Wattsup.Domain.Models;

namespace Wattsup.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class MeterReadingController : BaseEntityController<MeterReading>
{
    private readonly IMeterReadingService _meterReadingService;

    public MeterReadingController(IMeterReadingService meterReadingService) : base(meterReadingService)
    {
        _meterReadingService = meterReadingService;
    }
}