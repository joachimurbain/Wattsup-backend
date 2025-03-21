using Wattsup.Domain.CustomEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wattsup.Domain.Models;
public class Request
{
    public int Id { get; set; }
    public DateTime RequestedAt { get; set; }
    public RequestStatus Status { get; set; }

    public DateTime ExpiresAt => RequestedAt.AddDays(20);


    public required User RequestedBy { get; set; }
    public required Meter Meter { get; set; }
    public MeterReading? MeterReading { get; set; }
}
