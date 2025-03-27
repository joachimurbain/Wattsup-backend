using System.ComponentModel.DataAnnotations;

namespace Wattsup.Api.DTOs.StoreDTOs;
public class CreateStoreDto
{
    [Required]
    public required string Name { get; set; }

    [Required]
    public required string StoreCode { get; set; }

    [Required]
    public required string Address { get; set; }

    [Required]
    public required string City { get; set; }

    [Required]
    public int Zipcode { get; set; }

    [Required]
    public float SurfaceArea { get; set; }
    public bool IsActive { get; set; } = true;
    public int? ManagerId { get; set; }
}