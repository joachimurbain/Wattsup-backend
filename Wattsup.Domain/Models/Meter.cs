using CrudCore.Attributes;
using CrudCore.Interfaces;
using Wattsup.Domain.CustomEnums;


namespace Wattsup.Domain.Models;
public class Meter : IEntity, IValidatable
{
	public int Id { get; set; }

	public Guid Uuid { get; set; } = new Guid();

	public MeterType Type { get; set; }

	public DateTime? DeactivationDate { get; set; }

	[SkipAutoMapper]
	public required string QrCode { get; set; } // set in BLL

	public required int StoreId { get; set; }

	[SkipAutoMapper]
	public required Store Store { get; set; }

	public List<MeterReading> Readings { get; set; } = [];

	public void Validate()
	{
		if (string.IsNullOrWhiteSpace(QrCode))
		{
			throw new ArgumentException("QrCode Failed to generate.");
		}
	}
}

