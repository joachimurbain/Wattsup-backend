using CrudCore.Services;
using Wattsup.BLL.Services.Interfaces;
using Wattsup.DAL.Repositories.Interfaces;
using Wattsup.Domain.Models;

namespace Wattsup.BLL.Services;
public class StoreService : BaseService<Store>, IStoreService
{


	public StoreService(IStoreRepository storeRepository) : base(storeRepository) { }




}
