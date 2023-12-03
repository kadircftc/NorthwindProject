using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
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
            ProductManager productManager=new ProductManager(new EfProductDal());

            //foreach (var product in productManager.GetAll())
            //{
            //    Console.WriteLine(product.ProductName);
            //}


            OrderManager orderManager=new OrderManager(new EfOrderDal());  
            
            foreach(var order in orderManager.GetAll())
            {
                Console.WriteLine(order.CustomerId);
            }
        }
    }
}
