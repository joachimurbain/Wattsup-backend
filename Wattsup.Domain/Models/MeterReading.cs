using CrudCore.Interfaces;
using Wattsup.Domain.CustomEnums;


namespace Wattsup.Domain.Models;
public class MeterReading : IEntity, IValidatable
{
	public int Id { get; set; }
	public required int Value { get; set; }
	public required DateTime ReadingDate { get; set; }
	public MeterReadingSource Source { get; set; }

	public int MeterId { get; set; }
	public required Meter Meter { get; set; }


	public void Validate()
	{
		if (Value <= 0)
		{
			throw new ArgumentException("Value must be greater than 0");
		}
		if (ReadingDate < new DateTime(2020, 1, 1) || ReadingDate > DateTime.UtcNow.AddDays(1))
		{
			throw new ArgumentException("ReadingDate must be within a valid range");
		}
	}
}
