using ShopCore.Core.DataAccess.Concrete.EntityFramework;
using ShopCore.DataAccess.Abstract;
using ShopCore.DataAccess.Concrete.EntityFramework.Contexts;
using ShopCore.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCore.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryRepository:GenericRepositoryBase<Category, ShopContext>,ICategoryRepository
    {
    }
}
