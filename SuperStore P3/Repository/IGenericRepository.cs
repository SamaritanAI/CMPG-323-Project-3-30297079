using System.Linq.Expressions;

namespace EcoPower_Logistics.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        T Get(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> expression);
        void Add(T entity);
        void Delete(int id);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);

    }
}
