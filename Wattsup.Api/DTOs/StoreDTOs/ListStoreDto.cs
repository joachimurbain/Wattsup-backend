namespace Wattsup.Api.DTOs.StoreDTOs;

public class ListStoreDto
{
    public int Id { get; set; }
    public required string Name { get; set; } 
    public required string StoreCode { get; set; }
    public required string City { get; set; }
    public bool IsActive { get; set; }
}