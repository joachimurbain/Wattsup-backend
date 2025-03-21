using Wattsup.Domain.CustomEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wattsup.Domain.Models;
public class Notification
{
    public int Id { get; set; }
    public required string Message { get; set; }
    public DateTime CreationDate { get; set; }
    public DateTime ReadDate { get; set; }
    public NotificationType Type { get; set; }

    public required User User { get; set; }
    public Store? Store { get; set; }    

}
