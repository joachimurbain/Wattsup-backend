using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wattsup.Domain.Models;
public class Store
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Pcode { get; set; }
    public required string Address { get; set; }
    public required string City { get; set; }
    public float SurfaceArea { get; set; }
    public bool IsActive { get; set; } = true;

    public User? Manager { get; set; }
}
