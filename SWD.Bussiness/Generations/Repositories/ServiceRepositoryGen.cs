/////////////////////////////////////////////////////////////////
//
//              AUTO-GENERATED
//
/////////////////////////////////////////////////////////////////

using Microsoft.EntityFrameworkCore;
using Reso.Core.BaseConnect;
using SWD.Bussiness.Models;
namespace SWD.Bussiness.Repositories
{
    public partial interface IServiceRepository :IBaseRepository<Service>
    {
    }
    public partial class ServiceRepository :BaseRepository<Service>, IServiceRepository
    {
         public ServiceRepository(DbContext dbContext) : base(dbContext)
         {
         }
    }
}

