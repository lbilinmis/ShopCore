using ShopCore.Business.Abstract;
using ShopCore.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCore.Core.DataAccess.Abstract
{
    public interface IProductService : IGenericService<Product>
    {
    }
}
