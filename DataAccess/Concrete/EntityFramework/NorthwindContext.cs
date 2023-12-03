using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DataAccess.Concrete.EntityFramework
{
    //Context:Db tabloları ile proje classlarını bağlamak
    public class NorthwindContext:DbContext
    {
        //db tabloları ile proje classlarını bağlıyoruz benim
        //veri tabanım tam olarak şurada demektir
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=.\SQLEXPRESS;initial catalog=Northwind;persist security info=False;user id=sa;password=1;TrustServerCertificate=True;");
        }
      
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

    }
}
