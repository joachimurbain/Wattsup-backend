using Wattsup.Domain.CustomEnums;
using Wattsup.Domain.Models;

namespace Wattsup.Api.DTOs.MeterDTOs;

public class DetailsMeterDTO
{

    public int Id { get; set; }
    public Guid Uuid { get; set; } = new Guid();
    public MeterType Type { get; set; }
    public DateTime? DeactivationDate { get; set; }
    public required string QrCode { get; set; }

    public required int StoreId { get; set; }
    //public List<MeterReading> Readings { get; set; } = [];

}
