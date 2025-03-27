namespace Wattsup.Api.DTOs.StoreDTOs;

public class UpdateStoreDto
{
    public string? Name { get; set; } 
    public string? StoreCode { get; set; } 
    public string? Address { get; set; }
    public string? City { get; set; }
    public int? Zipcode { get; set; }
    public float? SurfaceArea { get; set; }
    public bool? IsActive { get; set; }
    public int? ManagerId { get; set; }
}
