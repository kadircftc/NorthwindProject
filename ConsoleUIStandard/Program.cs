using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ProductTest();

            //OrderTest();

            //CategoryTest();

            ProductDtoTest();

        }

        private static void ProductDtoTest()
        {
            ProductManager productManeger = new ProductManager(new EfProductDal());
            foreach (var product in productManeger.GetProductDetails())
            {
                Console.WriteLine(product.ProductName + "/" + product.CategoryName);
            }
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }


            List<Category> categories = categoryManager.GetByIdCategories(new int[] { 1, 3, 2, 5 });
            foreach (Category category in categories)
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void OrderTest()
        {
            OrderManager orderManager = new OrderManager(new EfOrderDal());

            foreach (var order in orderManager.GetAll())
            {
                Console.WriteLine(order.CustomerId);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
