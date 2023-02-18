using Autofac;
using ShopCore.Business.Abstract;
using ShopCore.Business.Concrete;
using ShopCore.Core.DataAccess.Abstract;
using ShopCore.DataAccess.Abstract;
using ShopCore.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCore.Business.DependecyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CategoryManager>().As<ICategoryService>();
            builder.RegisterType<EfCategoryRepository>().As<ICategoryRepository>();

            builder.RegisterType<ProductManager>().As<IProductService>();
            builder.RegisterType<EfProductRepository>().As<IProductRepository>();

            builder.RegisterType<OrderManager>().As<IOrderService>();
            builder.RegisterType<EfOrderRepository>().As<IOrderRepository>();
        }
    }
}
