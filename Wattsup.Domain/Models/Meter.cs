using Wattsup.Domain.CustomEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wattsup.Domain.Interfaces;

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
