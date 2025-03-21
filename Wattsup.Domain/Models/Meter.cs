using Wattsup.Domain.CustomEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wattsup.Domain.Models;
public class Meter
{
    public int Id { get; set; }
    public Guid Uuid { get; set; } = new Guid();
    public MeterType Type { get; set; }
    public DateTime DeactivationDate { get; set; }
    public required string QrCode { get; set; }


    public required Store Store { get; set; }
}
