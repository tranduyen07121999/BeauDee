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
    public partial interface ICustomerServiceRepository :IBaseRepository<CustomerService>
    {
    }
    public partial class CustomerServiceRepository :BaseRepository<CustomerService>, ICustomerServiceRepository
    {
         public CustomerServiceRepository(DbContext dbContext) : base(dbContext)
         {
         }
    }
}

