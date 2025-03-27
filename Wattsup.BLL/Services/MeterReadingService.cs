using Wattsup.BLL.Services.Base;
using Wattsup.BLL.Services.Interfaces;
using Wattsup.DAL.Repositories.Interfaces;
using Wattsup.Domain.Models;

namespace Wattsup.BLL.Services;
public class MeterReadingService : BaseService<MeterReading>, IMeterReadingService
{


	public MeterReadingService(IMeterReadingRepository MeterReadingRepository) : base(MeterReadingRepository) { }


}
