﻿using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
        Product GetById(int productId);
        List<Product> GetAll();
        List<Product> GetAllByCategory(int id);
        List<Product> GetByUnitPrice(decimal min,decimal max);
        List<ProductDetailDto> GetProductDetails(); 

    }
}
