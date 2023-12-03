using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    //generic constraint 
    //class: referans tip olabilir demek
    // burada bir kural yazdık dedik ki sadece IEntity
    // olan ya da IEntityden implemente eden sınıflar yazılabilir T için
    //ama IEntity soyut nesne işimizi görmez
    //bu yüzden eğer new() yazarsak sadece onu implemente eden sınıflar yazılabilir
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        //Expression<Func<T, bool>> filter = null yapısı filtre verebilmek için yani p=>p.ProductId==product.ProductId gibi

        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
