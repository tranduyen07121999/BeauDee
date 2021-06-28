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
    public partial interface IProductRepository :IBaseRepository<Product>
    {
    }
    public partial class ProductRepository :BaseRepository<Product>, IProductRepository
    {
         public ProductRepository(DbContext dbContext) : base(dbContext)
         {
         }
    }
}

