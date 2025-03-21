using Wattsup.Domain.CustomEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wattsup.Domain.Models;
public class User
{
    public int Id { get; set; }
    public required string Firstname { get; set; }
    public required string Lastname { get; set; }
    public required string Email { get; set; }
    public required string Password { get; set; }
    public bool IsActive { get; set; } = true;


    public required Role Role { get; set; }
}
