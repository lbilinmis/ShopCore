using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCore.Entities.Concrete
{
    public class Product
    {
        //Çokaçok ilişki olmasını sağlamaktayız
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }


    }
}
