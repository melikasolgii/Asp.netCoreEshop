using ASP.NetCoreEShop._0_framework.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Linq.Expressions;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace ASP.NetCoreEShop._0_framework.Infrastructure
{
    public class RepositoryBase<TKey,T> : IRepository<TKey,T> where T : class
    {
        private readonly DbContext _context;

        public RepositoryBase(DbContext context)
        {
            _context = context;
        }
       
        public void Create(T entity)
        {
            _context.Add(entity);
        }

        public bool Exists(Expression<Func<T, bool>> expression)
        {
            //This is a method that checks if at least one entity in a database set matches a specified condition.

            //The Set<T>() method returns a DbSet<T> object, which is a set of entities that can be queried.
           // Any(expression): This is a LINQ method that checks if any element in the set matches the specified condition.
            return _context.Set<T>().Any(expression);
        }

        public T Get(TKey id)
        {
            return _context.Find<T>(id);
        }

        public List<T> Get()
        {
           return _context.Set<T>().ToList();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }

}
