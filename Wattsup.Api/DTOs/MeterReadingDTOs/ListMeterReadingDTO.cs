namespace Wattsup.Api.DTOs.MeterReadingDTOs;

public class ListMeterReadingDTO
{
	public int Id { get; set; }
	public int Value { get; set; }
	public DateTime ReadingDate { get; set; }
	public int MeterId { get; set; }
}
