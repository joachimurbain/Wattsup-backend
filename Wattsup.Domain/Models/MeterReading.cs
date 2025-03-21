using Wattsup.Domain.CustomEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wattsup.Domain.Models;
public class MeterReading
{
    public int Id { get; set; }
    public required int Value { get; set; }
    public required DateTime readingDate { get; set; }
    public MeterReadingSource Source { get; set; }

    public required Meter Meter { get; set; }
    public User? User { get; set; }
}
