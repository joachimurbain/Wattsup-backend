using Wattsup.Domain.CustomEnums;

namespace Wattsup.Api.DTOs.MeterReadingDTOs;

public class CreateMeterReadingDTO
{

	public int Value { get; set; }
	public DateTime ReadingDate { get; set; }
	public MeterReadingSource Source { get; set; }
	public int MeterId { get; set; }
}
