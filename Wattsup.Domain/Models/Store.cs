

using CrudCore.Interfaces;

namespace Wattsup.Domain.Models;
public class Store : IEntity, IValidatable
{
	public int Id { get; set; }
	public required string Name { get; set; }
	public required string StoreCode { get; set; }
	public required string Address { get; set; }
	public required string City { get; set; }
	public required int Zipcode { get; set; }
	public float SurfaceArea { get; set; }
	public bool IsActive { get; set; } = true;

	public User? Manager { get; set; }
	public List<Meter> Meters { get; set; } = [];

	//public void ApplyPatch(StoreUpdate patch)
	//{
	//	Name = patch.Name ?? Name;
	//	StoreCode = patch.StoreCode ?? StoreCode;
	//	Address = patch.Address ?? Address;
	//	City = patch.City ?? City;
	//	Zipcode = patch.Zipcode ?? Zipcode;
	//	SurfaceArea = patch.SurfaceArea ?? SurfaceArea;
	//	IsActive = patch.IsActive ?? IsActive;
	//	Manager = patch.Manager ?? Manager;
	//}

	public void Validate()
	{
		if (string.IsNullOrWhiteSpace(Name))
			throw new ArgumentException("Store name is required");

		if (string.IsNullOrWhiteSpace(StoreCode))
			throw new ArgumentException("Store code is required");

		if (string.IsNullOrWhiteSpace(Address))
			throw new ArgumentException("Address is required");

		if (string.IsNullOrWhiteSpace(City))
			throw new ArgumentException("City is required");

		if (Zipcode < 1000 || Zipcode > 9999)
			throw new ArgumentException("Invalid Belgian ZIP code");
	}
}
