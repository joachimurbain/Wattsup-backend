using Wattsup.Domain.CustomEnums;

namespace Wattsup.Api.DTOs.MeterDTOs;

public class CreateMeterDTO
{
	public MeterType Type { get; set; }
	public int StoreId { get; set; }

}
