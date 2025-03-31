using Wattsup.Domain.CustomEnums;

namespace Wattsup.Api.DTOs.StoreDTOs;

public class DetailsMeterReadingDto
{
	public int Id { get; set; }
	public int Value { get; set; }
	public DateTime ReadingDate { get; set; }
	public MeterReadingSource Source { get; set; }
	public int MeterId { get; set; }
}
