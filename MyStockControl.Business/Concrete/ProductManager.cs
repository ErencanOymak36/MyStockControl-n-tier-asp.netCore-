using AutoMapper;
using MyStockControl.Business.Abstract;
using MyStockControl.DataAccess.Dal.Abstract;
using MyStockControl.Entities.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStockControl.Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
   
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
            

        }
        public void AddProduct(Product product)
        {
          
           _productDal.Add(product);
            
          
        }

        public void DeleteProduct(Product product)
        {
            _productDal.Delete(product);
        }

        public List<Product> GetAll()
        {
            
           return _productDal.GetAll();
        }

        public Product GetByCategoryId(int categoryId)
        {
            return _productDal.Get(p => p.CategoryId == categoryId);
        }

        public Product GetById(int id)
        {
            return _productDal.Get(p=>p.ProductId == id);
        }

        public Product GetByPrice(double price)
        {
            return _productDal.Get(p => p.Price == price);
        }

        public void UpdateProduct(Product product)
        {
           _productDal.Update(product);
        }
    }
}
