using Wattsup.Api.DTOs.MeterDTOs;
using Wattsup.Domain.Models;

namespace Wattsup.Api.DTOs.StoreDTOs;

public class DetailsStoreDto
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string StoreCode { get; set; }
    public required string Address { get; set; }
    public required string City { get; set; }
    public int Zipcode { get; set; }
    public float SurfaceArea { get; set; }
    public bool IsActive { get; set; }
    public User? Manager { get; set; }
    public List<DetailsMeterDTO> Meters { get; set; } = [];
}
