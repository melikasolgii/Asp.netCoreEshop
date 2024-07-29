using System.Linq.Expressions;

namespace ASP.NetCoreEShop._0_framework.Domain
{
    public interface IRepository<TKey ,T> where T:class
    {
        T Get(TKey id); //get Tkey(id) and return T(entity)
        List<T> Get();
        void Create(T entity);
        bool Exists(Expression<Func<T, bool>> expression); //all except it self 
        void SaveChanges();

    }
}
