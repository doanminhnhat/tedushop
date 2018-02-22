using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Model;

namespace TeduShop.Data.Repositories
{
    public interface IFooterRepositor 
    { 

    }
    public class FooterRepository : RepositoryBase<Footer>, IFooterRepositor
    {
        public FooterRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {

        }
    }
}
