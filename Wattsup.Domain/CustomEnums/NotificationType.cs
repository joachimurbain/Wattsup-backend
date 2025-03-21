using Wattsup.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wattsup.Domain.CustomEnums;
public enum NotificationType
{
    MissingReading,
    AbnormalConsumption, 
    RequestExpiration,
    SystemMessage
}
