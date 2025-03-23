namespace Wattsup.Domain.Models;
public class StoreUpdate
{
	public int Id { get; set; }
	public string? Name { get; set; }
	public string? StoreCode { get; set; }
	public string? Address { get; set; }
	public string? City { get; set; }
	public int? Zipcode { get; set; }
	public float? SurfaceArea { get; set; }
	public bool? IsActive { get; set; }
	public User? Manager { get; set; }
}
