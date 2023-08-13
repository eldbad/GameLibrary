using System.Linq.Expressions;

namespace GameLibrary.Application.Common;

public interface IRepository<T> where T : class
{
    IQueryable<T> FindAll();
    IQueryable<T> FindByCondition(Expression<Func<T, bool>> condition);
    T? FindFirstByCondition(Expression<Func<T, bool>> condition);
    void Create(T entity);
    void Update(T entity);
    void Delete(T entity);
}