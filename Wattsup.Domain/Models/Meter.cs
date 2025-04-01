using Wattsup.Domain.CustomEnums;
using CrudCore.Interfaces;


namespace Wattsup.Domain.Models;
public class Meter : IEntity
{
    public int Id { get; set; }
    public Guid Uuid { get; set; } = new Guid();
    public MeterType Type { get; set; }
    public DateTime? DeactivationDate { get; set; }
    public required string QrCode { get; set; }

    public required Store Store { get; set; }
    public List<MeterReading> Readings { get; set; } = [];


}
