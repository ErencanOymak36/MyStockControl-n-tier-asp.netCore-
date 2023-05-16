using MyStockControl.Entities.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStockControl.Business.Abstract
{
    public interface IProductService
    {
         List<Product> GetAll();
        Product GetById(int id);
        Product GetByPrice(double price);
        Product GetByCategoryId(int categoryId);
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(Product product);
    }
}
