using ShopCore.Core.DataAccess.Abstract;
using ShopCore.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCore.DataAccess.Abstract
{
    public interface ICategoryRepository:IGenericRepository<Category>
    {
    }
}
