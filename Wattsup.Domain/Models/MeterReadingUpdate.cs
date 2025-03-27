using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wattsup.Domain.CustomEnums;

namespace Wattsup.Domain.Models;
public class MeterReadingUpdate
{
    public int Id { get; set; }
    public  int? Value { get; set; }
    public  DateTime? readingDate { get; set; }
}
