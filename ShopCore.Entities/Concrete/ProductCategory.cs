using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCore.Entities.Concrete
{
    public class ProductCategory
    {
        // çoka çok ilişkili product ve category tablolarının tanımlanması için  kullanıldı
        public int Id { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
