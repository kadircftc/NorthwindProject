using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
           _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }
        public void Update(Product product)
        {
           _productDal.Update(product);
        }
        public List<Product> GetAll()
        {
            //iş kodları
            return _productDal.GetAll();
            
        }

        public List<Product> GetAllByCategory(int id)
        {
            return _productDal.GetAll(p=>p.CategoryId == id);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
        }

        public List<ProductDetailDto> GetProductDetails()
        {
           return _productDal.GetProductDetails();
        }

        public Product GetById(int productId)
        {
            return _productDal.Get(p=>p.ProductId == productId);
        }
    }
}
