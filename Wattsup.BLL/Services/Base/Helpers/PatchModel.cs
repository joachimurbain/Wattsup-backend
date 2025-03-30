namespace Wattsup.Api.Controllers.Base.Helpers;

public class PatchModel<T> where T : class
{
	public T PartialEntity { get; set; } = default!;
	public HashSet<string> UpdatedFields { get; set; } = new();
}