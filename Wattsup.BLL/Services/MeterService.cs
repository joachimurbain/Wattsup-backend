using CrudCore.Services;
using Wattsup.BLL.Services.Interfaces;
using Wattsup.DAL.Repositories.Interfaces;
using Wattsup.Domain.Models;

namespace Wattsup.BLL.Services;
public class MeterService : BaseService<Meter>, IMeterService
{


	public MeterService(IMeterRepository MeterRepository) : base(MeterRepository) { }


	public override Task<Meter> AddAsync(Meter entity)
	{
		entity.QrCode = "abc";
		return base.AddAsync(entity);
	}

}
