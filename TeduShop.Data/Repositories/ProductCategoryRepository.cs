using System;
using System.Collections;
using System.Collections.Generic;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Model;
using System.Linq;
namespace TeduShop.Data.Repositories
{
    public interface IProductCategoryRepository
    {
        IEnumerable<ProductCategory> GetByAlias(string alias);
    }
    public class ProductCategoryRepository : RepositoryBase<ProductCategory>, IProductCategoryRepository
    {
        public ProductCategoryRepository(IDbFactory dbfactory)
            :base(dbfactory)
        {
            
        }

        public IEnumerable<ProductCategory> GetByAlias(string alias)
        {
            return this.DbContext.ProductCategories.Where(x =>x.Alias == alias);
        }
    }
}